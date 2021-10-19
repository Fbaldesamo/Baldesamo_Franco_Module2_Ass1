using System;

namespace Baldesamo_Franco_Module2_Ass1
{
    internal class Program
    {
        private class Add
        {
            //polymor has been used here
            public static double Compute(double a, double b, double c, double d, double e)
            {
                double a1 = a;
                double a2 = b;
                double a3 = c;
                double a4 = d;
                double a5 = e;

                double total = a1 + a2 + a3 + a4 + a5;

                return total;
            }
        }

        private class Product : Add
        {
            //polymore has been used here
            public static double Compute(double a1, double a2, double a3, double a4, double a5)
            {
                double total = (a1 * a2 * a3 * a4 * a5);

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
                    Console.WriteLine("Your Input Number: " + number);
                }
            }
            //add total = new add();
            double ct = Add.Compute(uservals[0], uservals[1], uservals[2], uservals[3], uservals[4]);
            Console.WriteLine("Total of all num: " + ct);
            //multiply
            double cp = Product.Compute(uservals[0], uservals[1], uservals[2], uservals[3], uservals[4]);
            Console.WriteLine("Product of all num: " + cp);

            Console.ReadKey();
        }
    }
}