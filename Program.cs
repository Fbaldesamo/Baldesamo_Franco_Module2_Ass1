using System;

namespace Baldesamo_Franco_Module2_Ass1
{
    internal class Program
    {
        class Add
        {
            public static double Compute(double a, double b, double c, double d, double e)
            {
                 double total = a + b + c + d + e;

                return total;
            }



        }
        class Product : Add
        {
            public static double Compute()
            {
                double total = a * b;

                return total;
            }


        }
        private static void Main(string[] args)
        {
         
            //for how many can be inputted
            int userint = 0;

            //make a list
            int usermany = 5;
            double[] uservals = new double[usermany];

            //uver list index
            int userval = 0;

            //get input until not 5 input
            while (userint != 5)
            {
                Console.Write("Input a Number: ");
                uservals[userval] = double.Parse(Console.ReadLine());

                userval++;
                userint++;
            }
            Console.Clear(); //clean all the input
            if (userint == 5)
            {
                
                    foreach (int number in uservals)
                    {
                        Console.WriteLine("Your Input Number: "+ number);
                    }
                
                
            }
            //add total = new add();
            Add.Compute(uservals[0], uservals[1], uservals[2], uservals[3], uservals[4]);


            Console.ReadKey();
        }
    }
}