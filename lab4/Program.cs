using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Factorial Calculator!\n");
            Console.WriteLine("Enter an integer that's greater than 0 but less than 10:\n");
            string numberToCountDownFrom = Console.ReadLine();


            int value = Convert.ToInt32(numberToCountDownFrom);


            if (value > 0 || value < 10) {



                for (value  = 0; value < 5; i++)
                {
                    Console.WriteLine(i);


                }





                //for (int i = 0; i < 10; i++) ;
            }
    }
}