using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmos_distintos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stopwatch contador = new Stopwatch();
            contador.Start();
            int[] num = new int[8];
            num[0] = 8;
            num[1] = 10;
            num[2] = 5;
            num[3] = 11;
            num[4] = 33;
            num[5] = 75;
            num[6] = 75;
            num[7] = 80;
            int suma = num[0] + num[1] + num[2] + num[3] + num[4] + num[5] + num[6] + num[7];
            Console.WriteLine("La suma de los numeros es: " + suma);
            contador.Stop();
            Console.WriteLine("Tiempo en ejecucion:{0}", contador.Elapsed.ToString());

            Stopwatch sw1 = Stopwatch.StartNew();
            sw1.Start();
            Console.WriteLine("La suma de los numeros es:");
            List<int> numeros = new List<int> { +8 + 10 + 5 + 11 + 33 + 75 + 75 + 80 };
            foreach (int i in numeros)
            { Console.WriteLine(i); }
            contador.Stop();
            Console.WriteLine("Tiempo en ejecucion:{0}", contador.Elapsed.ToString());
            Console.ReadLine();
        }
    }
}
