using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, n, maxN, minN;
            n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            array[0] = int.Parse(Console.ReadLine());
            maxN = array[0]; minN = array[0];
            for (i = 1; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
                if (maxN < array[i]) maxN = array[i];
                if (minN < array[i]) minN = array[i];
            }
            Console.WriteLine("Max =" + maxN);
            Console.WriteLine("Min =" + minN);
            int brMin = 0, brMax = 0;
            for (i = 0; i < n; i++)
            {
                if (minN == array[i])
                {
                    brMin++;
                }
                if (maxN == array[i])
                {
                    brMax++;
                }
                Console.WriteLine("brMin= " + brMin);
                Console.WriteLine("brMax= " + brMax);  
                

            }
        }
    }
}
