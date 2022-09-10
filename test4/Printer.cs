using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test4
{
    public class Printer
    {
        public int DoublePrinter()
        {
            Console.WriteLine("1 - лазерный принтер");
            Console.WriteLine("2 - пискоструйный принтер");

            int printer = int.Parse(Console.ReadLine());

            if (printer == 1)
            {
                Console.WriteLine("Используем лазерный принтер");
            }

            else if (printer == 2)
            {
                Console.WriteLine("Используем пискоструйный принтер");
            }

            else
            {
                Console.WriteLine("1 или 2");
            }






            return printer;
        }
    }
}
