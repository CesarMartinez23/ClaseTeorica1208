using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//César Jacob Martinez Alvarenga. Codigo: SMIS055621

namespace ClaseTeorica1208
{
    class Program
    {
        static void Main(string[] args)
        {
            //Lllamado al metodo loops
            loops();

            Console.ReadKey();

        }

        //Bucles

        public static void loops()
        {

            int[] numbers = new int[3];
            numbers[0] = 5;
            numbers[1] = 10;
            numbers[2] = 15;

            //Ciclo While

            int i = 0;
            Console.WriteLine("IMPRIME ELEMENTOS CON EL CICLO WHILE");
            while (i < numbers.Length)
            {
                Console.WriteLine(numbers[i]);
                i++;
            }

            //Ciclo DO-WHILE

            Console.WriteLine("IMPRIME ELEMENTOS CON EL CICLO DO-WHILE");
            int inc = 0;
            do
            {
                Console.WriteLine(numbers[inc]);

                inc++;
            } while (inc < numbers.Length);

            //Ciclo FOR

            Console.WriteLine("IMPRIME ELEMENTOS CON EL CICLO FOR");
            for(int j=0; j < numbers.Length; j++)
            {
                Console.WriteLine("Posicion {0} : {1}", j, numbers[j]);
            }

            //Ciclo FOREACH
            Console.WriteLine("IMPRIME ELEMENTOS CON EL CICLO FOREACH");

            foreach(int item in numbers)
            {
                Console.WriteLine(item);
            }



            Console.WriteLine();

            //Ejercicio de Clase
            {
                int[] arraynumeros = new int[10];

                int sumaTotal=0;
                double promedio;

                int n = 0;
                
                while (n < arraynumeros.Length)
                {
                    Console.WriteLine("Ingrese el valor en la posicion {0}",n);
                    arraynumeros[n] = Convert.ToInt32(Console.ReadLine());
                    n++;
                }


                Console.WriteLine();

                Console.WriteLine("Mostrando datos del array ARRAYNUMEROS");


                int m = 0;
                Console.WriteLine("IMPRIME ELEMENTOS CON EL CICLO WHILE");
                while (m < arraynumeros.Length)
                {
                    Console.WriteLine(arraynumeros[m]);
                    m++;
                }

                Console.WriteLine();

                //Calculando Promedio
                for (int count = 0; count < 10; count++)
                {
                    sumaTotal = sumaTotal + arraynumeros[count];
                }
                promedio = sumaTotal / arraynumeros.Length;

                Console.WriteLine("El promedio de los datos ingresados es: {0}", promedio);
                
            }
        }
    }
}