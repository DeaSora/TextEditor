using System;


namespace TextEditor
{
    public class Printer
    {
        public int DoublePrinter()
        {
            Console.WriteLine("1 - laser printer");
            Console.WriteLine("2 - sandblast printer");

            var printer = int.Parse(Console.ReadLine());

            if (printer == 1)
            {
                Console.WriteLine("Use laser printer");
            }

            else if (printer == 2)
            {
                Console.WriteLine("Use sandblast printer");
            }

            else
            {
                Console.WriteLine("1 or 2");
            }

            return printer;
        }
    }
}
