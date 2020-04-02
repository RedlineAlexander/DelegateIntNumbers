using System;
using System.Collections.Generic;
using System.Linq;
namespace LINQLINQLINQLINQLINQ
{
    class Program
    {
        static void Main(string[] args)
        {

            var AnonymoMamaMioPandemio = new {
            name = "Topic VOOZ",
            back = 2
            };
            Console.WriteLine(AnonymoMamaMioPandemio.name, AnonymoMamaMioPandemio.back);
            var MyDataSupportFarmastor = new
            {
                first = "Alexander",
                second = "Kukhar",
                state = "Employee of Farmastor",
                profession = "Technical Support Engineer",
                workingexperience = "6 months"

            };
            Console.WriteLine(MyDataSupportFarmastor.first, MyDataSupportFarmastor.workingexperience);

            Action lineactionline = () => Console.WriteLine("Our pandemic carantine ACTION DELEGATE LINE");
            Action<int, string> lineactionofmylife = (back, description) => { Console.WriteLine($"{back} {description}"); };
            Predicate<int> NoPositivePredicate = (x) => { return x > 4; };
            Func<int, int, string> func = delegate (int a, int b) 
            {

                return (a + b).ToString(); 
                      
             };

            lineactionofmylife(4, "predicate tasks");
            NoPositivePredicate(5);
            func(1, 2);


            string[] fruits = { "peachez", "mangos", "oranges"};

            int minimalLength = fruits.Where(f => f.StartsWith("o"))
                                .Min(f => f.Length);
            Console.WriteLine(minimalLength);
                
            object[] prepare = { "", 2, '1', 34, 34, 11 };


            IEnumerable<object> prepareManyObjectToPeople = from prepa in prepare
                                                            select prepa;
            
            foreach(object quapeople in prepareManyObjectToPeople)
            {
                Console.WriteLine(quapeople);
            }
            string[] pandemiWorld = { "new", "from", "China", "Europe", "USA", "Ukraine", "Where the end" };

            IEnumerable<string> pandemiQueryLINQ = from pandem in pandemiWorld
                                                   where pandem == "from"
                                                   select pandem;

            foreach(string xday in pandemiQueryLINQ)
            {
                Console.WriteLine(xday);
            }
            Console.ReadKey();
            //Console.WriteLine("Hello World!");


            
        }

        public int MyDelInMethod(int first, int second, int third)
        {
            return first + second + third;
        }
    }
}
