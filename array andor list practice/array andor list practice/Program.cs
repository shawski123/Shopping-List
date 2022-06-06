using System;
using System.Collections.Generic;

namespace practice // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int shoppingNum;

            Console.Write("How many items do you have in your shopping list: ");
            while (int.TryParse(Console.ReadLine(), out shoppingNum) == false || shoppingNum == 0)
            {

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nPlease enter a valid number!\n");
                Console.ResetColor();
            }
            Console.WriteLine("\nPlease list the items\n");
            string[] shoppingCart = new string[shoppingNum];
            for (int i = 0; i < shoppingCart.Length; i++)
            {
                shoppingCart[i] = Console.ReadLine();
            }

            Console.WriteLine("---------------");
            Array.Sort(shoppingCart);
            
            for (int i = 0; i < shoppingCart.Length; i++)
            {
                Console.WriteLine(shoppingCart[i]);
            }
            
            
        }
    }
}