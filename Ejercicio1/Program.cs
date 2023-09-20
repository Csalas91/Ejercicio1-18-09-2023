using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    internal class Program
    {
        public struct Empleado
        {
            int codigo;
            string nombre;
            float salario;
        }
        static void Main(string[] args)
        {

            // tipos de datos 
            int num1, num2;// numeros enteros
            short corto = 5660;//
            num1 = 5877;
            float flotante = 3.14f;//simpre poner "f" al final
            double doble = 15.2d;//poner "d" al final
            decimal deci = 15.15m;//poner "m" al final
            byte b = 25;// entero
            long larga = 123456789132456;//numero largos
            ulong ulargo = 56;// numero pequeños
            Boolean boleano = false;// opcion verdadero o falso
            char Letra = 'a';// una letra
            string cadena = "Hoy es lunes 18 de setiembre";// opcion para oraciones

            // var // dynanmic

            var variable = 15.25f;// se puede usar cualquier dato 
            dynamic dinamica = 25.3f;// se puede combinar datos en todo el codigo
            dinamica = "Nombre empleado";//
            dinamica = true;//
            dinamica = 'c';//

            // arreglos 
            int n = 4;
            string[] musico = new string[n];// tipo de dato,nombre variable, inicializacion del arreglo
            string[] temporal = new string[n];
            musico[0] = "Carlos";
            musico[1] = "Maria";
            musico[2] = "Sofia";
            musico[3] = "Eva";

            float[] salario = new float[100];
            /*
             * i = 0, 1,2,3,4

             */
            for (int i = 0; i < salario.Length; i++)
            {
                Console.WriteLine("Digite el salario:");// para imprimir
                salario[i] = float.Parse(Console.ReadLine());// para convertir de string a float
            }

            if (true)
            {

            }

            while (true) { }

            do
            {

            } while (true);



            Console.WriteLine("Listado de musicos");

            Console.WriteLine(musico[0]);
            Console.WriteLine(musico[1]);
            Console.WriteLine(musico[2]);
            Console.WriteLine(musico[3]);




            Console.ReadLine();
            string[] nombres = new string[] { "Ringo", "George", "Paul", "John" };


        }

    }

}