using System;

namespace TextEditor
{
    public class TextEditor
    {
        public int Editor()
        {
            Console.WriteLine("1 - keyboard input");
            Console.WriteLine("2 - to add a file");
            var option = int.Parse(Console.ReadLine());

            if (option == 1)
            {
                Console.WriteLine("Enter text: ");
                Console.ReadLine();

                var Printer = new Printer();
                Printer.DoublePrinter();
            }
            else if (option == 2)
            {
                Console.WriteLine("Adding a file: ");
                StreamReader rdr = new StreamReader(@"D:\test1.txt");
                Console.WriteLine(rdr.ReadToEnd());
                rdr.Close();
            }
            else
            {
                Console.WriteLine("1 or 2");
            }

            return option;
        }

    }
}
