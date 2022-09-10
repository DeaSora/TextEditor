using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace test4
{
    public class TextEditor
    {
        public int Editor()
        {
            Console.WriteLine("1 - ввод с клавиатуры");
            Console.WriteLine("2 - добавить файл");

            int a = int.Parse(Console.ReadLine());

            if (a == 1)
            {
                Console.WriteLine("Введите текст: ");
                Console.ReadLine();

                var Printer = new Printer();
                Printer.DoublePrinter();
            }


            else if (a == 2)
            {
                Console.WriteLine("Добавляем файл: ");
                StreamReader rdr = new StreamReader(@"D:\test1.txt");
                Console.WriteLine(rdr.ReadToEnd());
                rdr.Close();
            }


            else
            {
                Console.WriteLine("1 или 2");
            }





            return a;

        }

    }
}
