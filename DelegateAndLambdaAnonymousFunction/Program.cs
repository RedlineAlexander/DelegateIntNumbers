using System;
using System.Collections.Generic;
using System.Linq;

namespace DelegateAndLambdaAnonymousFunction
{
    public delegate string StopFake(string fake);
    public delegate string FakeNewsEvent(object sender, EventArgs e);

    class Program
    {
        public event Action OnBase = delegate {};
        public void RaiseFM()
        {
            OnBase();
        }
        static void Main(string[] args)
        {


            Program program = new Program();
            StopFake stopFake = (fake) => fake;
            var result = stopFake("FAKE JAVA NEWS");
            Console.WriteLine(result);
            program.OnBase += () => Console.WriteLine("FAKE SUB 1");
            program.OnBase += () => Console.WriteLine("FAKE SUB 2");
            program.RaiseFM();
             

        Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }
}
