using System;
using System.Threading;


namespace Logproject
{
    class Program
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        static void Main(string[] args)
        {
            Console.WriteLine("Enter input number:");
            var userInput = Convert.ToInt32(Console.ReadLine());

            var watch = System.Diagnostics.Stopwatch.StartNew(); //Start the loop stopper
            for (int i = 0; i < userInput; ++i)
            {
                Console.WriteLine(i); //Print it only for execution
            }
            watch.Stop(); //stop the stopper
            Console.WriteLine(watch.ElapsedMilliseconds.ToString() + "ms");
            Thread.Sleep(5000); //Take a 5s to show the result on the console
            log.Info(" " + userInput);//Send this data to log file

        }
    }
}
