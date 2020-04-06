using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeChange
{
    class Program
    {
        static void Main(string[] args)
        {
            //Prompt the user for a purchase amount
            //Read in the purchase amount from the user

            Console.Write("Purchase amount: $");
            double price;
            price = double.Parse(Console.ReadLine());

            //Prompt the user for the payment amount
            //Read in the payment amount from the user

            Console.Write("Payment amount: $");
            double payment;
            payment = double.Parse(Console.ReadLine());

            //Compute the change due
            //Print out the change due

            double changedue = payment - price;
            Console.WriteLine("Change due: ${0}", changedue);
            changedue += 0.000001;

            //change in 20s

            int twenties = (int) (changedue / 20);
            Console.WriteLine("Twenties:{0}", twenties);
            changedue -= twenties * 20;
            
            //change in 10s

            int tens = (int) (changedue / 10);
            Console.WriteLine("Tens:{0}", tens);
            changedue -= tens * 10;
            
            //change in 5s

            int fives = (int) (changedue / 5);
            Console.WriteLine("Fives:{0}", fives);
            changedue %= 5;
            
            //change in 1s

            int ones = (int) (changedue / 1);
            Console.WriteLine("Ones:{0}", ones);
            changedue %= 1;
            
            //change in .25

            int quarters = (int) (changedue / 0.25);
            Console.WriteLine("quarters:{0}", quarters);
            changedue %= 0.25;
            
            //change in .10

            int dimes = (int) (changedue / 0.10);
            Console.WriteLine("dimes:{0}", dimes);
            changedue %= 0.10;
            
            //change in .05

            int nickels = (int) (changedue / 0.05);
            Console.WriteLine("nickels:{0}", nickels);
            changedue %= 0.05;
            
            //change in .01

            int pennies = (int) (changedue / 0.01);
            Console.WriteLine("pennies due:{0}", pennies);
            changedue %= 0.01;
            
        }

    }
}
