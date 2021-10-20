using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Falmark___chapter_16
{
    class Program
    {
         
        static void Main(string[] args)
        {
            Console.WriteLine("This are the item that are available in the Shop");
            String[] item = { "Shoes", "Pencil", "Notebook", "Cellphone", "Ruler", "Erasers","Paper" };
            foreach(string i in item)
            {
                Console.WriteLine(i);

            }
            method1();
           
        }
        static void method1()
        {
            Console.Write("how many number you want to add to cart: ");
            customearrayList<string> shoppingList = new customearrayList<string>();
            int shop = Convert.ToInt32(Console.ReadLine());
            for(int a = 0; a < shop; a++)
            {
                Console.Write("item: " + (a + 1) + ": ");
                string Shop = Console.ReadLine();
                shoppingList.add(Shop);     
            }

            Console.Write("Would you like to remove a item in the cart? [Y/N]  ");
            string me = Console.ReadLine();
            if (me == "Y" || me == "y")
            {
                Console.Write("item to Remove: ");
                string rem = Console.ReadLine();
                shoppingList.remove(rem);
                Console.WriteLine(rem + " has remove");

                Console.Write("insert a item to cart: ");
                string tr = Console.ReadLine();
                shoppingList.insert(2, tr);
                Console.WriteLine("the item that i needed ", shoppingList);
                for (int i = 0; i < shoppingList.Count; i++)
                {
                    Console.WriteLine("-" + shoppingList[i]);

                }
            
                Console.WriteLine("Position of 'Paper' = {0}", shoppingList.indexOF("Paper"));
                Console.WriteLine("Position of 'Cellphone' = {0}",
                shoppingList.indexOF("Cellphone"));
                Console.WriteLine("Do we have to buy Pencil? " + shoppingList.contains("Pencil"));

            }
            else if (me == "N" || me == "n" )
            {
                Console.Write("insert a item to cart: ");
                string tr = Console.ReadLine();
                shoppingList.insert(2, tr);
                Console.WriteLine("the item that i needed ", shoppingList);
                for (int i = 0; i < shoppingList.Count; i++)
                {
                    Console.WriteLine("-" + shoppingList[i]);

                }
                Console.WriteLine("Position of 'Paper' = {0}", shoppingList.indexOF("Paper"));
                Console.WriteLine("Position of 'Cellphone' = {0}",
                shoppingList.indexOF("Cellphone"));
                Console.WriteLine("Do we have to buy Pencil? " + shoppingList.contains("Pencil"));
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }

        }
    }
}

   
