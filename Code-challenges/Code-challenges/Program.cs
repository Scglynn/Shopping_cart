// apples .50
//orange .75

using System;

namespace ShoppingCart
{
    public class ShoppingCartItem
    {
        public double Calculations(double apple, double orange)
        {
            double total_sum = 0;
            if(apple != 0)
            {
                for(int i = 0; i < apple; i++)
                {
                    total_sum +=.50;
                }
            }
            if(orange != 0)
            {
                for(int j = 0; j < orange; j++)
                {
                    total_sum += .75;
                }
            }
            return total_sum;
        }
        public static void Main(string[] args)
        {
            double num_apple = 0;
            string apples;
            double num_oranges = 0;
            string oranges;
            Console.WriteLine("Enter the number apples: ");
            num_apple = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the number oranges: ");
            num_oranges = Convert.ToDouble(Console.ReadLine());

            ShoppingCartItem item = new ShoppingCartItem();
            double sum = item.Calculations(num_apple, num_oranges);

            Console.WriteLine(" You owe: $" + sum);
            /*
             enter number apple = 2
            "                   " = 3

            if (apple > 0)
            for()
                .50 + .50 = 1.00

            if (orange != 0)
            For()
                .75 +. 75 + .75 = 2.25


            total sum = 3.25
             */
            //

        }
    }
}