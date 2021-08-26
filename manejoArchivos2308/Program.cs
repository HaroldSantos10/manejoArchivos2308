using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; //permitira trabajar con las clases para manipular archivos 

namespace manejoArchivos2308
{
    class Program
    {
        static void Main(string[] args)
        {
            //definir la ruta del archivo 
            string path = @"C:\ejemplosC#\datos.txt";

            //evaluar si el archivo existe para ya no crearlo
            if (File.Exists(path))
            {
                Console.WriteLine("El archivo ya esxiste!");

                //Leer el contenido del archivo linea por linea
                String[] lines;
                lines = File.ReadAllLines(path);
                for (int i = 0; i< lines.Length; i++)
                {
                    Console.WriteLine(lines[i]);
                }

                //leer el contenido del archivo
                Console.WriteLine("CONTENIDO UTILIZANDO ReadAllLines()");
                String content;
                content = File.ReadAllText(path);
                Console.WriteLine(content);


            }
            else
            {
                 //crear un archivo, y agregar texto
                using (StreamWriter sr = File.AppendText(path))
                {
                    //contenido del archivo
                    sr.WriteLine("Programación computacional I");
                    sr.WriteLine("Clase teorica | Stream I/O");
                    sr.Close();
                }

            }



            
        }
    }
}
