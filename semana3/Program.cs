using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace semana3
{
    class Program
    {
        static void Main(string[] args)
        {
            /// llamado al metoto loops
            loops();
            Console.ReadLine();

        }
        ///bucles
        public static void loops()
        {

            int[] numbers = new int[3];
            numbers[0] = 5;
            numbers[1] = 10;
            numbers[2] = 15;

            //ciclo while 
            int i = 0;
            Console.WriteLine("IMPREME ELEMENTOS CON WHILE");
            while (i < numbers.Length)
            {
                Console.WriteLine(numbers[i]);
                i=i+1; 
            }

            Console.WriteLine("IMPRIME ELEMENTOS ON DO-WHILE");
            int inc = 0;
            do
            {
                Console.WriteLine(numbers[inc]);
                inc++;
            } while (10 < numbers.Length);

            Console.WriteLine("IMPRIME ELEMENTOS CON FOR");
            for (int j = 0; j < numbers .Length; j++)
            {
                Console.WriteLine("Posicion {0} : {1}", j, numbers[j]);
            }

            Console.WriteLine("IMPRIME ELEMENTOS CON FOREACH");
            foreach(int item in numbers)
            {
                Console.WriteLine(item);
            }

            int sumatoria = 0; //aqlmacenara la sumatoria de los valores 

            Console.WriteLine("IMPRIME ELEMENTOS CON FOR - arreglo ordenado");
            //llamado a la clase array y el metodo sort
            Array.Sort(numbers); // el metodo sort permite ordenar los valores dentro del array
            for (int j = 0; j < numbers.Length; j++)
            {
                Console.WriteLine("Posicion {0} : {1}", j, numbers[j]);
                //sumar los valores dentro del array 
                //sumatoria = 0 + 5 ; numbers [0]
                //sumatoria = 5 + 10 ; numbers [1]
                sumatoria = sumatoria + numbers[j];
                //Console.WriteLine(sumatoria);
            }

            Console.WriteLine("IMPRIME ELEMENTOS CON FOREACH - ARREGLO INVERTIDO");
            Array.Reverse(numbers); //permite invertir los valores dentro del array
            foreach (int item in numbers) ;
            {
                Console.WriteLine("item");

            }
            //mostramos el valor promedio de los numeros del array 
            Console.WriteLine("El valor promedio es de : {0}", sumatoria / (numbers.Length));





            


        }









    }


}
