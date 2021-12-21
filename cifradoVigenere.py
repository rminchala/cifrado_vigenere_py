# -*- coding: utf-8 -*-   # esto sirve para poder tener acceso a los caracteres del alfabeto incluido la Ñ
"""
   Se utiliza self para referirse a un objeto o variable de la clase a la que pertenece 
   Created on Wed Oct 28 12:31:33 2020

   @author: ROBERTO
"""
#from numpy import *  # se llama a la librería para trabajar con arreglos
from datetime import datetime  #libreria para usar la fecha actual del sistema
LIMITE = 27
LMESSAGE = 50

#definición de la clase
class CifradoVigenere:
    #definicion de arreglos y variables de la clase (var globalels)
    tableAlphabet=[[0 for col in range(LIMITE)] for row in range(LIMITE)]   # definir una matriz de LIMITE x LIMITE
    datocifrado = [""]*LIMITE   #definir un arreglo vacio de caracteres de tamaño LIMITE
    msg = "  "
    clave = "  "
    TRUE,FALSE = 1, 0
      
    #El constructor se ejecuta automáticamente primero. sin necesidad de llamarlo o instanciarlo
    def __init__(self):      # this is the constructor that fill character alphabetic table
        self.letters=['A','B','C','D','E','F','G','H','I','J','K','L','M','N','Ñ','O','P','Q','R','S','T','U','V','W','X','Y','Z']
        self.fileLog=open("./logVigenere.txt","w")  #se abre un archivo de texto para logs (mensajes de errores) del programa
        self.now=datetime.now()        
        for i in range(LIMITE):  #i empieza en 0 hasta LIMITE-1
            #-- proceso para llenar la tabla de caracteres alfabéticos de izquierda a derecha --
            k=i  # indice para los caracteres alfabéticos de izquierda a derecha
            for j in range(LIMITE):
                if k < LIMITE:  #permite controlar que el indice k no se pase de la cantidad LIMITE de letras que hay en el vector de letras
                    self.tableAlphabet[i][j] = self.letters[k]
                #end if                               
                k+=1
            #end j
            
            # -- proceso para llenar la tabla de caracteres alfabéticos de derecha a izquierda --
            k=0
            for j in range(LIMITE-i,LIMITE):                
                self.tableAlphabet[i][j]=self.letters[k]
                k+=1
            #end j
        #end i                   
    #end init
    
    #this methodo print the character alphabetic table
    def printTableAlphabet(self):
        #impresion de la tabla
        print("\n\t\t\t TABLA VIGENERE\n\t\t\t **************\n")
        for i in range(LIMITE):
            for j in range(LIMITE):
                print(self.tableAlphabet[i][j],end=" ")  #imprimir con espacios separados
            #end j
            print()
    #end printTableAlphabet  
    
    # esta función permite verificar que se ingresen datos válidos y no caracetres especiales   
    def VerifyDataInput(self, data):                          
        now=datetime.now() #obtener la fecha actual del sistema
        self.fileLog.write(f" {now} -- archivo entrando a verificar datos\n") #se escribe la fecha actual en el archivo log
        flag=0
        while flag==0:         
            for i in range(len(data)):            
                if(data[i] not in(self.letters)):                  
                    self.fileLog.write(f" {datetime.now()} -- error . caracter desconocido. stop\n") 
                    flag=1
                    break               
                #end if
            #end for
            if(flag==1):              
                return self.TRUE
            else:
                flag=1
                return self.FALSE
        #end while
    #end verifyDataInput
      
    #this method read the message and clave from keyboard to find the vigenere cifrado
    #transform to upper the data input
    
    def GettingData(self):       
        self.msg = str(input("Ingrese el mensaje               : ")).upper()  
        self.clave = str(input("Ingrese la clave                 : ")).upper()
        self.msg = self.RemoveSpace(self.msg)     #se llama a la función RemoveSpace
    #end GettingData
   
    #this function remove empty space into any string characters
    def RemoveSpace(self,cadena):  #obligado a usar self como parametro caso contrario da error
        messageaux = cadena.replace(" ","") #reemplazar los espacios vacios con "nada"
        print(f"\nMensaje sin espacios             : {messageaux}")
        return messageaux
    #end RemoveSpace  
      
   # Ésta función rellena la clave con el mismo valor ssi la longitud de caracteres de la clave es menor que la longitud del mensaje          
    def FillClave(self,_clave, _msg):
        _claveaux = _clave # esta variable auxiliar sirve en lugar de hacer _clave[i] = clave[clavecar] que no se puede hacer en python
        tamclave = len(_clave) #se obtiene la longitud o tamaño de caracteres que tiene _clave
       
        if len(_clave) < len(_msg):
            clavecar = 0
            for i in range(len(_clave),len(_msg)): # equivale a : for i=len(clave); i<=len(_msg); i++
                _claveaux =_claveaux + _clave[clavecar]
                clavecar+=1
                if clavecar == tamclave:
                    clavecar = 0
                #end if
            #end for i
            print(f"Clave rellenada consigo mismo    : {_claveaux}")
            self.clave = _claveaux   # colocar en la variable clave su valor modificado es decir aumentado con caracteres de si mismo
        #end if
    #end FillClave
    
    # Ésta función busca el resultado del criptograma    
    
    def ProcessCifrado(self):
        _fil = 1
        _column = 2
        
        for i in range(len(self.msg)):               
            col = self.ReturnIndexRowCol(self.msg[i],_column)            
            row = self.ReturnIndexRowCol(self.clave[i],_fil)
            
            if (col < 0 or row < 0):
                print("there are a special character into the clave or in the message... can´t find the answer cifrado!!!")
                break  #salir del if
            else:                
                 self.datocifrado[i] = self.tableAlphabet[row][col]
            #end if
        #end for i
        result=""  #this variable serve to store result encryption clave vigenere
        #print("Resultado clave cifrada : ")
        for i in self.datocifrado:
            #print(i,end='')
            result+=i
        #end for i          
        print(f"Resultado clave cifrada          : {str(result)}")
    #end ProcessCifrado
    
    #this function return the row and column where so find the  character cifrado
    def ReturnIndexRowCol(self, caracter, colrow):
        _found = False
        index = 0
        while _found == False:
             if (colrow == 2):
                 if caracter == self.tableAlphabet[0][index]:
                     return index
                 else:
                     index+=1
                 #end if
             else:
                  if caracter == self.tableAlphabet[index][0]:
                      return index
                  else:
                      index+=1
                  #end if
              #end if
        #return -1
    #end ReturnIndexRowCol
         
#end class
    
vg = CifradoVigenere()
vg.printTableAlphabet()
vg.GettingData()
#cv.FillClave("cielo","hermoso")
# se verifica que los datos de entrada sean correctos
if (vg.VerifyDataInput(vg.clave)==vg.TRUE or vg.VerifyDataInput(vg.msg)==vg.TRUE):
    print("hay error en datos de entrada, existe algún caracter que no es letra")
else:
    vg.FillClave(vg.clave,vg.msg)
    vg.ProcessCifrado()
vg.fileLog.close()  # cerrar el archivo de texto