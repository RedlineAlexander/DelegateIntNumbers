using System;
using System.IO
using System.Windows.Forms;
namespace DelegateRichterAnalyze
{
    internal delegate void FeedBack(Int32 value);
    class Program
    {
        static void Main(string[] args)
        {
            StaticDelegateDemo();
            InstanceDelegateDemo();
            ChainDelegateMethodDemoOne(new Program());
            ChainDelegateMethodDemoTwo(new Program());
            Console.WriteLine("Hello World!");

        }
        private static void StaticDelegateDemo()
        {

        }
        private static void InstanceDelegateDemo()
        {

        }
        private static void ChainDelegateMethodDemoOne(Program p)
        {
            FeedBack feedBack = new FeedBack(FeedBackToConsole);
            FeedBack feedBack1 = new FeedBack(p.FeedBackToConsole);
            FeedBack feedBack2 = new FeedBack(FromMessageToBox);

            FeedBack feedBackChain = null;


            feedBackChain += feedBack;
            feedBackChain += feedBack1;
            feedBackChain += feedBack2;
            Counter(1, 2, feedBackChain);

            Console.WriteLine();
            feedBackChain -= new FeedBack(FromMessageToBox);
            Counter(1, 2, feedBackChain);

        }
        private static void ChainDelegateMethodDemoTwo(Program p)
        {
            FeedBack feedBack = new FeedBack(FeedBackToConsole);
            FeedBack feedBack1 = new FeedBack(p.FeedBackToFileConsole);
            FeedBack feedBack2 = new FeedBack(FromMessageToBox);

            FeedBack feedBackChain = null;

            feedBackChain = (FeedBack)Delegate.Combine(feedBackChain, feedBack);
            feedBackChain = (FeedBack)Delegate.Combine(feedBackChain, feedBack1);
            feedBackChain = (FeedBack)Delegate.Combine(feedBackChain, feedBack2);

            Console.WriteLine();
            feedBackChain = (FeedBack)Delegate.Remove(feedBackChain, new FeedBack(feedBackChain));
            Counter(1, 2, feedBackChain);




            
        }
        private static void FeedBackToConsole(Int32 value)
        {
            Console.WriteLine(" " + value);
        }

        private static void Counter(Int32 from, Int32 to, FeedBack feedBack)
        {
            for (int i = from; i <= to; i++)
            {
                if(feedBack != null)
                {
                    feedBack(i);
                }
            }
        }
        private static void FromMessageToBox(Int32 value)

        { 
            
        }
        private void FeedBackToFileConsole(Int32 value)
        {
            using (StreamWriter sw = new StreamWriter("Status", true))
            {
                sw.WriteLine("ItemFile" +value);
            }
        }
    }
}
