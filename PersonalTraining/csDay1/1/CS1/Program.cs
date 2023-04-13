using System;

namespace A011_FormatSpecifier
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("{0:N2}", 1234.5678);

            string s;
            s = string.Format("{0:N2}", 1234.5678);
            Console.WriteLine(s);
        }

    }
}
