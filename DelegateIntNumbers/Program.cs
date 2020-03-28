using System;

namespace DelegateIntNumbers

{
    public delegate String MyIntegerDelegate(int Myinteger);

    class Program
    {
        public string DetermineStringSymbolMathMethod(int MyInteger)
        {
            if (MyInteger > 0)
            {
                return ("+");
            }
            if(MyInteger < 0)
            {
                return ("-");
            }
            return (" ");
        }

        public static string DetermineStringMethod(int MyInteger)
        {
            if (MyInteger > 0)
            {
                return ("Positive");
            }
            else
            {
                return ("Negative");
            }
            return ("");
        }
        static void Main(string[] args)
        {
            Program program = new Program();
            MyIntegerDelegate MYI = new MyIntegerDelegate(program.DetermineStringSymbolMathMethod);
            MyIntegerDelegate MYI32 = new MyIntegerDelegate(Program.DetermineStringMethod);


            Console.WriteLine(MYI(2), MYI32(2));
            Console.WriteLine(MYI(2), MYI32(2));
            Console.WriteLine(MYI(2), MYI32(2));
           // Console.WriteLine();
          //  Console.WriteLine();

            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }
}
