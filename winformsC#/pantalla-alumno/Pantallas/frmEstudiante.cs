using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using practica_al.Datos; //usar la carpeta Datos ya que ahi están las clases tambien la clase que funciona como var globla valor
using MiLibreria;        //usar la libreria dll creada llamada MiLibreria.

namespace practica_al.Pantallas
{
    public partial class frmEstudiante : Form
    {
        ClsEstudiante objStudent = new ClsEstudiante();

        //private bool botonPresionado = false;
        private bool findrecord = true;
        private bool botonConsultaPresionado = false;
        string operacionTipo = "insert";
        private string[] arr_genero = new string[] { "MASCULINO", "FEMENINO" };
       
        private string v_genero;
        public frmEstudiante()
        {
            InitializeComponent();
        }
        private void FrmEstudiante_Load(object sender, EventArgs e)
        {
            string color = "#6495ed "; // color azul claro      #FFB000" --> color mostaza 
            dataGridView1.RowHeadersVisible = false;  //para quitar la primera columna que tiene asterisco del grid
            // auto ajustar el ancho de las columnas al texto en el grid
            dataGridView1.AutoResizeColumns();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            // definir color mostaza en los encabezados del grid
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml(color); //("#BFDBFF"); color celeste
            // esta propiedad hace que seleccione toda la fila del grid, tambiém se puede hacer usando las propiedades del grid
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            // deshabilitar propiedad de edicion a solo lectura y no escritura
            dataGridView1.ReadOnly = true;

            ShowStudent(); //mostrar el grid de todos los registros existentes
           
        }
        private void Btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            timer1.Start(); //para controlar el tiempo para que se desaparezca todos estos controles

            botonConsultaPresionado = true;
            lblconsulta.Text = "Ingrese Código a Consultar :";
            lblconsulta.Visible = true;
            textConsulta.Visible = true;
            btnok.Visible = true;
            textConsulta.Focus();            
        }

        private void Btnagregar_Click(object sender, EventArgs e)
        {
            int insertYesNo;
            textBox1.Text = operacionTipo;
            if (operacionTipo == "insert")
            {
                v_genero = cmbgenero.Text;
                if (v_genero == arr_genero[0] || v_genero == arr_genero[1])
                {
                    if (string.IsNullOrWhiteSpace(textpaterno.Text) || String.IsNullOrWhiteSpace(textmaterno.Text) || String.IsNullOrWhiteSpace(textnombre.Text))
                    {
                        MessageBox.Show(" Datos erróneos,...debe ingresar toda la información requerida ");
                    }
                    else
                    {                        
                        objStudent._last_name = textpaterno.Text.Trim();
                        objStudent._middle_name = textmaterno.Text.Trim();
                        objStudent._first_name = textnombre.Text.Trim();
                        objStudent._gender = cmbgenero.SelectedItem.ToString();
                        insertYesNo = objStudent.InsertStudent();
                        if (insertYesNo == 1)
                            MessageBox.Show("REGISTRO YA EXISTE");
                        else
                            MessageBox.Show("REGISTRO DE INSERTO CORRECTAMENTE");
                        
                        operacionTipo = "insert";                     
                    }
                    ShowStudent();
                    CleanForm();  //limpiar el formulario    
                }//ig vgenero          
               else
                {
                    MessageBox.Show("error en datos, debe seleccionar el genero");
                   
                }
            } //if operaciontype
            else
                MessageBox.Show("No se puede Insertar registro, ya existe o está en Edición de registro");                       
        }
        //metodp para limpiar la pantalla (textbox)
        private void CleanForm()
        {
            textpaterno.Clear();
            textmaterno.Clear();
            textnombre.Clear();
            textgenero.Clear();
            
        }
        private void ShowStudent()  //colocar los datos de la tabla student en el datagrid
        {
            dataGridView1.DataSource = objStudent.ListStudent();
        }

        private void Btnactualiza_Click(object sender, EventArgs e)
        {
           if(operacionTipo == "edit" )
            {
                objStudent._last_name = textpaterno.Text.Trim();
                objStudent._middle_name = textmaterno.Text.Trim();
                objStudent._first_name = textnombre.Text.Trim();
                // preguntar si seleccionó un género a modificar
                if(cmbgenero.SelectedIndex == 1 || cmbgenero.SelectedIndex == 2)
                {
                    objStudent._gender = cmbgenero.SelectedItem.ToString();
                } 
                else // si no es verdad, colocamos el mismo género que tenia ya que no se ha modificado
                {
                    objStudent._gender = textgenero.Text.Trim();
                }
                objStudent.EditStudent();
                MessageBox.Show(" Registro actualizado!!! ");
                ShowStudent();
                CleanForm();
                operacionTipo = "insert";
            }
           else
            {
                MessageBox.Show(" Seleccione alguna fila\n o algún registro para editar");
            }
           
        }
     
        // método que sirve para que al dar un clic en la fila del datagrid, ésta información sea puesto en 
        // las cajas de textbox.
        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
                int _row = dataGridView1.CurrentCell.RowIndex;  //se obtiene la fila actual del datagrid
            
                objStudent._id_student = Convert.ToInt32(dataGridView1[0, _row].Value.ToString());  //es el Id del estudiante
                textpaterno.Text = dataGridView1[1, _row].Value.ToString();  // datagridview1[columna,fila]
                textmaterno.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString(); //para usar _row hay que hacer:dataGridView1[2, _row].Value.ToString();
                textnombre.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                textgenero.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                operacionTipo = "edit";            //
                         
        }

        
        private void textnombre_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void btnelimina_Click(object sender, EventArgs e)
        {
           
            if (operacionTipo=="edit") //significa que hay datos en la pantalla a eliminar
            {
                // PROCEDER A ELIMINAR EL REGISTRO
                MessageBox.Show("ESTA SEGURO QUE DESEA ELIMINAR EL REGISTRO ?");

                DialogResult result = MessageBox.Show("ESTA SEGURO QUE DESEA ELIMINAR EL REGISTRO?", "Salir", MessageBoxButtons.YesNoCancel);

                switch (result)
                {
                    case DialogResult.Yes:
                        MessageBox.Show("Yes");
                        break;
                    case DialogResult.No:
                        MessageBox.Show("No");
                        break;
                    case DialogResult.Cancel:
                        MessageBox.Show("Cancel");
                        break;
                }
            }
            else
                MessageBox.Show(" DEBE CONSULTAR O SELECCIONAR EL REGISTRO A ELIMINAR");
                        
        }

        private void btnok_Click(object sender, EventArgs e) //busqueda de registros
        {           
            string code = textConsulta.Text.Trim();  //el contenido del textbox a consultar 

            dataGridView1.DataSource = objStudent.SearchStudent(code); //solo devuelve 1 registro de la consulta con el código que se envía a
            //se verifica que si el registro es o no null ya que si es nulo entonces no existe el registro en la bd
            if(dataGridView1.CurrentRow == null)  
            {
                MessageBox.Show("REGISTRO NO EXISTE");
            }
            else
            {
                textpaterno.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();  // datagridview1[columna,fila]
                textmaterno.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString(); //para usar _row hay que hacer:dataGridView1[2, _row].Value.ToString();
                textnombre.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                textgenero.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                operacionTipo = "edit";
            }
           

        }
        
        //Método del control timer para ser usado en los controles que desaparecen en 3 segundos
        private void timer1_Tick(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(textConsulta.Text) || botonConsultaPresionado)
            {
                //desaparece estos controles bajo la condicion if
                lblconsulta.Visible = false;
                textConsulta.Visible = false;
                textConsulta.Text = "";
                btnok.Visible = false;
            }
           //textBox1.Visible = false; //textbox donde se muestra el estado de la pantalla : insercion/edicion
        }

        private void button1_Click_1(object sender, EventArgs e)  //boton mostrar todos los registros 
        {
            ShowStudent(); //mostrar el grid de todos los registros existentes
        }
    }
}
