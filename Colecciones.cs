using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseTeorica1208
{
    class Colecciones
    {
        static void Main(String[] args)
        {
            //diccionario
            //almacena pares de datos clave y valor
            //Definir un diccionario

            Dictionary<string, string> EmployeList = new Dictionary<string, string>();

            //Agregar elementos al diccionario
            EmployeList.Add("Jose Flores", "Programador");
            EmployeList.Add("Miranda Campos", "Generente");
            EmployeList.Add("Carmen Valladares", "Arquietecta");

            Dictionary<string, int> Students = new Dictionary<string, int>();
            Students.Add("Jose Flores", 20);
            Students.Add("Miranda Campos", 22);
            Students.Add("Carmen Valladares", 24);

            //Leer el diccionario y mostrar los datos 
            foreach (KeyValuePair<string,string> employee in EmployeList)
            {
                Console.WriteLine("Clave: {0}, Valor: {1}", employee.Key, employee.Value);
            }

            //Ordenar los elementos del diccionario

            var dic = EmployeList.Keys.ToList();
            dic.Sort();

            Console.WriteLine("Diccionario Ordenado");
            foreach (var item in dic)
            {
                Console.WriteLine("{0}: {1}", item, EmployeList[item]);
            }

            //Contar los elementos del diccionario
            Console.WriteLine("Elemtos en el diccionario: {0}", EmployeList.Count);

            Console.WriteLine();
            //Ejercicio 3 de la clase
            Dictionary<string, int> FamiliaMartinez = new Dictionary<string, int>();
            FamiliaMartinez.Add("Cesar Martinez", 43);
            FamiliaMartinez.Add("Ana Alvarenga", 40);
            FamiliaMartinez.Add("Mateo Martinez", 12);
            FamiliaMartinez.Add("Cesarito Martinez", 19);

            //Leer el diccionario y mostrar los datos 

            foreach (KeyValuePair<string, int> mar in FamiliaMartinez)
            {
                Console.WriteLine("Clave: {0}, Valor: {1}", mar.Key, mar.Value);
            }

            Console.WriteLine();
            //Ordenar los elementos del diccionario

            var fam = FamiliaMartinez.Keys.ToList();
            fam.Sort();

            Console.WriteLine("Diccionario Ordenado");
            foreach (var sec in fam)
            {
                Console.WriteLine("{0}: {1}", sec, FamiliaMartinez[sec]);
            }

            Console.WriteLine();
            //Contar los elementos del diccionario
            Console.WriteLine("Elemtos en el diccionario: {0}", FamiliaMartinez.Count);
            Console.ReadKey();
        }
    }
}
