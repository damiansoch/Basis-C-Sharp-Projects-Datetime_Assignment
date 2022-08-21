using System;

namespace Datetime_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime timeNow = new DateTime();
            timeNow = DateTime.Now;
            Console.WriteLine(timeNow);
            Console.WriteLine("Please write the number");
            double number = Convert.ToDouble(Console.ReadLine());

            DateTime timeFuture = new DateTime();
            timeFuture = timeNow.AddHours(number);


            //this is based on the time that was printed to the console at the start, not the current time
            Console.WriteLine("In {0} hours it will be exactly {1} (based on the time printed before)", number, timeFuture);

            //this is based on the time that the user is actually getting the results at
            timeNow = DateTime.Now;
            timeFuture = timeNow.AddHours(number);
            Console.WriteLine("In {0} hours it will be exactly {1} (based on the current time)", number, timeFuture);

            Console.ReadKey();

        }
    }
}
