using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_While_Schleifen
{
    class Program
    {
        static void Main(string[] args)
        {
            //Do-While-Schleifen
            int number = 7;

            do
            {
                Console.WriteLine(number);
                number += 1;
            }
            while (number <= 5);

            Console.ReadKey();

        }
    }
}
