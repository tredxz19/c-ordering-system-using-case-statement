using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CASE_PRACTICE
{
    internal class Program
    {
        static void Main(string[]args)
        {
            while(true)
            { 
            double adobo = 50;
            double money = 0.00;
            string point = ".00 Pesos";
                string notice = "Your order is ";
            int orders;

            Console.Write("Please select your order:");
            int num = Convert.ToInt32(Console.ReadLine());
                switch (num)
                {
                    case 1:
                        Console.WriteLine(notice + "Adobo = 50.00 Pesos");
                        Console.Write("How many order do you want:");
                        orders = Convert.ToInt32(Console.ReadLine());
                        Console.Write("How much your money:");
                        money = Convert.ToInt32(Console.ReadLine());                   
                       
                        
                            if ((money) > (adobo * orders))
                        {
                            Console.WriteLine("The total amount is: "+(adobo * orders)+point);
                            Console.WriteLine("Your change is " + ((money) - (adobo * orders))+point);
                        }
                            else

                        Console.WriteLine("Sorry you dont have enough money");

                        break;


                    default:
                        Console.WriteLine("This is not 1 or 2"); break;
                }
            }
            Console.ReadKey(); 
        }
    }
}
