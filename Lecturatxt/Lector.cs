using System;
using System.Collections;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecturatxt
{
    public class Lector
    {
       

       
        public void ejecutar() {
            leer();         
        }
        public  void leer() {
            int j;
            char i;
            StreamReader lectura;           
            long paln = 0;
            long ora = 0;
            long alfa=0 ;
            long parra = 0;
            String file;
            String txt;
            try
            {
                Console.WriteLine("La ruta del archivo txt");
                file = Console.ReadLine();
                lectura = File.OpenText(file);
                txt = lectura.ReadLine();
                while (txt!=null){
                    for (j = 0; j < txt.Length; j++)
                    {
                        i = txt[j];
                        int c = char.ToLower(i);
                        if ((c == 'a') | (c == 'b') | (c == 'c') | (c == 'd') | (c == 'e') | (c == 'f') | (c == 'g') | (c == 'h') | (c == 'i') | (c == 'j') | (c == 'k') | (c == 'l') | (c == 'm') | (c == 'o') | (c == 'p') | (c == 'q') | (c == 'r') | (c == 's') | (c == 't') | (c == 'u') | (c == 'v') | (c == 'w') | (c == 'x') | (c == 'y') | (c == 'z') |
                            (c == 'A') | (c == 'B') | (c == 'C') | (c == 'D') | (c == 'E') | (c == 'F') | (c == 'G') | (c == 'H') | (c == 'I') | (c == 'J') | (c == 'K') | (c == 'L') | (c == 'M') | (c == 'O') | (c == 'P') | (c == 'Q') | (c == 'R') | (c == 'S') | (c == 'T') | (c == 'U') | (c == 'V') | (c == 'W') | (c == 'X') | (c == 'Y') | (c == 'Z') |
                            (c == '0') | (c == '1') | (c == '2') | (c == '3') | (c == '4') | (c == '5') | (c == '6') | (c == '7') | (c == '8') | (c == '9'))
                        {
                            alfa++;
                        }
                        else if (c == 'n' || c == 'N')
                        {
                            paln++;
                        }
                        else if (c == '.' && c > 15)
                        {
                            ora++;
                        }
                    }
                    
                    parra++;
                    txt = lectura.ReadLine();                     
                }          
                Console.WriteLine("La cantidad de caracteres alfanumericos es de :"+alfa);
                Console.WriteLine("La cantidad de palabras por n o N es de:" + paln);
                Console.WriteLine("La cantidad de oraciones en el texto es de :" + ora);
                Console.WriteLine("La cantidad de parrafos en el texto es de :" + parra);
                lectura.Close();
                Console.WriteLine("Escriba la ruta donde desea guardar y crear el archivo txt");
                txt = Console.ReadLine();
                StreamWriter sw = new StreamWriter(txt);
                sw.WriteLine("La cantidad de caracteres es :" + alfa);
                sw.WriteLine("La cantidad de palabras por n o N es de:" + paln);
                sw.WriteLine("La cantidad de oraciones en el texto es de :" + ora);
                sw.WriteLine("La cantidad de parrafos en el texto es de :" + parra);
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception" + e.Message);
            }
            finally
            {
                Console.WriteLine("lectura de archivo txt termianda ");
            }

        }

        public void imprimir()
        {
        }
        public void imprimirtodos() 
        {         
        }
       

    }
}
