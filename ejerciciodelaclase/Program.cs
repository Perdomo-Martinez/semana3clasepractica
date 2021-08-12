using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejerciciodelaclase
{
    class Program
    {
        static void Main(string[] args)
        {
            // escribir un ciclo que permita capturar los valores
            // a almacenar en el arreglo de numbers con un tamaño de 10 

            int[] numbers = new int[9];

            for (int s = 0; s < numbers.Length; s++)
            {
                Console.WriteLine("Introduce los numeros");
                numbers[s] = Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine("Estos son los numeros numeros");
            foreach (int item in numbers)
            {
                Console.WriteLine(item);
            }
          //Console.ReadKey();


            //CLASE PRACTICA
            // CALCULAR EL PROMEDIO DE LOS NUMEROS ALMACENADOS EN EL ARRAY

            


            //crear un diccionario con los datos de  familiares, almacene el nombre y edad,
            //incluya su datos e imprimir los datos del diccionario ordenados 


            Dictionary<string, string> famililist = new Dictionary<string, string>();

            famililist.Add("paty jurado", "madre");
            famililist.Add("digna jurado", "abuela");
            famililist .Add("robin perdomo", "hermano");
            famililist.Add("diana perdomo", "hermana");

            foreach (KeyValuePair<string, string> Employe in famililist)
            {
                Console.WriteLine("clave: {0}, valor: {1}", famililist.Keys, famililist.Values);
            }
            var dicc = famililist.Keys.ToList();
            dicc.Sort();

            Console.WriteLine("diccionario ordenado");
            foreach (var ite in dicc)
            {
                Console.WriteLine("{0} : {1}", ite, famililist.Count);



            }
            Console.ReadKey();


        }
    }
}
