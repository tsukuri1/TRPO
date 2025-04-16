using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float g = 1;    
            float h = 2;    
            float d17 = 3;  

            float ee = (g * h / d17) + (d17 / h) - ((g + d17 + h) / 4);

            Console.WriteLine("Результат вычисления: " + ee);
        }
    }
}
