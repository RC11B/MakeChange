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
            Console.Write("Purchase amount \n");
            double price;
            price = double.Parse(Console.ReadLine());
            Console.WriteLine(price);

            Console.Write("Payment amount");
            double payment;
            payment = double.Parse(Console.ReadLine());

            double changedue = payment - price;
            Console.WriteLine("Change due:${0}", changedue);
            changedue += 0.000001;

            int twenties = (int) (changedue / 20);
            Console.WriteLine("Twenties due:{0}", twenties);
            changedue = changedue - twenties * 20;
            


            int tens = (int)(changedue / 10);
            Console.WriteLine("Tens due:{0}", tens);
            changedue -= tens * 10;
            

            int fives = (int)(changedue / 5);
            Console.WriteLine("Fives due:{0}", fives);
            changedue = fives % 5;
            


            int ones = (int)(changedue / 1);
            Console.WriteLine("Ones due:{0}", ones);
            changedue %= 1;
            

            int quarters = (int)(changedue / 0.25);
            Console.WriteLine("quarters due:{0}", quarters);
            changedue %= 0.25;
            

            int dimes = (int)(changedue / 0.10);
            Console.WriteLine("dimes due:{0}", dimes);
            changedue %= 0.10;
            

            int nickles = (int)(changedue / 0.05);
            Console.WriteLine("nickles due:{0}", nickles);
            changedue %= 0.05;
            

            int pennies = (int)(changedue / 0.01);
            Console.WriteLine("pennies due:{0}", pennies);
            //changedue %= 0.01;
            

        }
    }
}
