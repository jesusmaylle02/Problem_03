using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeroNotas;
            float sumaNotas = 0;
            float promedio;

            Console.Write("Ingrese el número de notas: ");
            numeroNotas = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numeroNotas; i++)
            {
                Console.Write("Ingrese la nota " + i + ": ");
                float nota = float.Parse(Console.ReadLine());

                sumaNotas += nota;
            }

            promedio = sumaNotas / numeroNotas;

            Console.Write("El promedio es: " + promedio);

            Console.ReadKey();
        }
    }
}
