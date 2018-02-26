using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheRestOfRaunt
{
    class Program
    {

        static void Main(string[] args)
        {
            
            string seating, menu, order, drink;

            //worst name ever
            Console.WriteLine("Welcome to Munch Crunch a Bunch!");
            Console.ReadLine();

            //seating
            Console.WriteLine("Where would you like to sit?\r\n1 - Table\n\r2 - Booth");
            seating = Console.ReadLine();
            if (seating == "1")
            {
                Console.WriteLine("Alright, follow me to your table.");
            }
            if (seating == "2")
            {
                Console.WriteLine("Alright, follow me to your booth.");
            }
            else if (seating != "1" && seating != "2")
            {
                Console.WriteLine("Okay...I guess we can serve you standing up...");
            }
            Console.ReadLine();
            
            Console.WriteLine("And what menu would you like? \n\r1 - Breakfast\n\r2 - Lunch\n\r3 - Dinner");

            //menu type
            menu = Console.ReadLine();
            if (menu == "1")
            {
                order = BreakfastMenu();
                Console.WriteLine($"Alright! I'll put in your {order} order.");
            }
            if (menu == "2")
            {
                order = LunchMenu();
                Console.WriteLine($"Alright! I'll put in your {order} order.");
            }
            if (menu == "3")
            {
                order = DinnerMenu();
                Console.WriteLine($"Alright! I'll put in your {order} order.");
            }
            else if (menu != "1" && menu != "2" && menu != "3")
            {
                Console.WriteLine("No food? That's fine.");
            }

            //glug glug
            Console.ReadLine();
            Console.WriteLine("Here's our drink menu.");
            drink = DrinkMenu();
            Console.WriteLine($"Great! I'll be right out with your {drink}.");
            Console.ReadLine();
            
            
            Console.WriteLine("Enjoy your meal!");
            Console.ReadLine();

        }
        private static string BreakfastMenu()
        {
            string[] breakfast = new string[] { "1 - Pancakes", "2 - Waffles", "3 - Eggs", "4 - Bacon", "5 - Sausage"};
            Console.WriteLine("Here's your breakfast menu: (All items Market Price)");
            Console.ReadLine();
            foreach (string i in breakfast)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("So what would you like?");
            string choice = Console.ReadLine();
            string order = "";
            if (choice == "1")
            {
                order = "pancakes";
            }
            if (choice == "2")
            {
                order = "waffles";
            }
            if (choice == "3")
            {
                order = "eggs";
            }
            if (choice == "4")
            {
                order = "bacon";
            }
            if (choice == "5")
            {
                order = "sausage";
            }
            else if (choice != "1" && choice != "2" && choice != "3" && choice != "4" && choice != "5")
            {
                order = "nothing";
            }
            return order;
        }
        private static string LunchMenu()
        {
            string[] lunch = new string[] { "1 - Salad", "2 - Burger", "3 - Nachos", "4 - Tacos" };
            Console.WriteLine("Here's your lunch menu: (All items Market Price)");
            Console.ReadLine();
            foreach (string i in lunch)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("So what would you like?");
            string choice = Console.ReadLine();
            string order = "";
            if (choice == "1")
            {
                order = "salad";
            }
            if (choice == "2")
            {
                order = "burger";
            }
            if (choice == "3")
            {
                order = "nachos";
            }
            if (choice == "4")
            {
                order = "tacos";
            }
            else if (choice != "1" && choice != "2" && choice != "3" && choice != "4")
            {
                order = "nothing";
            }
            return order;
        }
        private static string DinnerMenu()
        {
            string[] dinner = new string[] { "1 - Salad", "2 - Soup", "3 - Steak", "4 - Salmon", "5 - Spaghetti"};
            Console.WriteLine("Here's your dinner menu: (All items Market Price)");
            Console.ReadLine();
            foreach (string i in dinner)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("So what would you like?");
            string choice = Console.ReadLine();
            string order = "";
            if (choice == "1")
            {
                order = "salad";
            }
            if (choice == "2")
            {
                order = "soup";
            }
            if (choice == "3")
            {
                order = "steak";
            }
            if (choice == "4")
            {
                order = "salmon";
            }
            if (choice == "5")
            {
                order = "spaghetti";
            }
            else if (choice != "1" && choice != "2" && choice != "3" && choice != "4" && choice != "5")
            {
                order = "nothing";
            }
            return order;
        }
        private static string DrinkMenu()
        {
            string[] drinks = new string[] { "1 - Water", "2 - Soda", "3 - Beer", "4 - Wine" };
            string order = "";
            Console.ReadLine();
            
            while (order == "")
            {
                Console.WriteLine("So what would you like?");
                foreach (string i in drinks)
                {
                    Console.WriteLine(i);
                }

                string choice = "";
                choice = Console.ReadLine();
                if (choice == "1")
                {
                    order = "water";
                   
                }
                if (choice == "2")
                {
                    order = "soda";
                   
                }
                if (choice == "3" || choice == "4")
                {
                    Console.WriteLine("Could I see some ID, please?");
                    Console.ReadLine();
                    Console.Write("Please enter your Date of Birth (MM/DD/YYYY): ");
                    DateTime birth = DateTime.Parse(Console.ReadLine());
                    TimeSpan age = DateTime.Now.Subtract(birth);
                    if (age.TotalDays < 7665)
                    {
                        Console.WriteLine("I'm sorry, you're not old enough to order that.");
                        Console.ReadLine();

                    }
                    else if (age.TotalDays >= 7665)
                    {
                        if (choice == "3")
                        {
                            order = "beer";                           
                        }
                        else if (choice == "4")
                        {
                            order = "wine";    
                        }
                    }
                }

                else if (choice != "1" && choice != "2" && choice != "3" && choice != "4")
                {
                    order = "nothing";
                }
                
            }
          
            return order;
          
        }
    }
}
