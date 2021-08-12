using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejerciciodelaclase
{
    class colecciones
    {

        static void Main(string[] args)
        {
            //7diccionario
            //almacena pares de dato clave y valor 
            Dictionary<string, string> EmployeeList = new Dictionary<string, string>();

            //agregar elementos al diccionario
            EmployeeList.Add("Jose Flores", "programador");
            EmployeeList.Add("miranda campos", "gerente");
            EmployeeList.Add("carmen valladares", "arquitecta");

            Dictionary<string, int> students = new Dictionary<string, int>();
            students.Add("jose flores", 22);
            students.Add("miranda campos", 20);
            students.Add("carmen valladares", 24);

            //leer el diccionario y mostrar los datos 
            foreach (KeyValuePair<string, string> Employe in EmployeeList)
            {
                Console.WriteLine("clave: {0}, valor: {1}", EmployeeList.Keys, EmployeeList.Values);
            }

            // ordenar elementos del diccionario
            var dic = EmployeeList.Keys.ToList();
            dic.Sort();

            Console.WriteLine("diccionario ordenado");
            foreach (var item in dic)
            {
                Console.WriteLine("{0} : {1}", item, EmployeeList.Count);

                Console.ReadKey();

            }


            //contar elementos de un diccionario
            Console.WriteLine("elementos en el dicionario{0}", EmployeeList.Count);

            Console.ReadKey();

           

        }
    }
}
