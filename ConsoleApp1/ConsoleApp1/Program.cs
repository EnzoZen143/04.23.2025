/*using System;
namespace MyApplication
{
    class Toon
    {
        string name;
        string role;
        string type;
        static void Main(string[] args)
        { 
            Toon DandicusDancifer = new Toon();
            DandicusDancifer.name = "Dandicus Dancifer";
            DandicusDancifer.role = "Shopkeeper";
            DandicusDancifer.type = "Flower";

            Toon AstroNovalite = new Toon();
            AstroNovalite.name = "Astro Novalite";
            AstroNovalite.role = "Stamina";
            AstroNovalite.type = "Crescent Moon";

            Toon SproutSeedly = new Toon();
            SproutSeedly.name = "Sprout Seedly";
            SproutSeedly.role = "healer";
            SproutSeedly.type = "Strawberry";

            Toon ShellyFossilian = new Toon();
            ShellyFossilian.name = "Shelly Fossilian";
            ShellyFossilian.role = "Extractor";
            ShellyFossilian.type = "Ammonite Shell";

            Toon VeeVersion1 = new Toon();
            VeeVersion1.name = "Vee Version 1";
            VeeVersion1.role = "Extractor";
            VeeVersion1.type = "TV";

            Toon PebbleDanciferJunior = new Toon();
            PebbleDanciferJunior.name = "Pebble Dancifer JR.";
            PebbleDanciferJunior.role = "Distractor";
            PebbleDanciferJunior.type = "Pet Rock";

            Toon Bobette = new Toon();
            Bobette.name = "Bobette";
            Bobette.role = "Extractor";
            Bobette.type = "Bauble";

            Toon Bassie = new Toon();
            Bassie.name = "Bassie";
            Bassie.role = "Support";
            Bassie.type = "Flower Basket";
        }
    }
}*/

/*using System;
using System.Collections.Generic;

namespace InventorySystem
{
    class Program
    { 
        //Create a list to store inventory items
        static List<string> inventory = new List<string>();
        static void Main(string[] args)
        {
            bool running = true;
            //Run the menu loop until the user exits
            while (running == true)
            {
                //Press 1 View Inventory
                //Press 2 Add Item in Inventory
                //Press 3 Remove Item
                //Press 4 Exit
                Console.WriteLine("=== SIMPLE INVENTORY SYSTEM===");
                Console.WriteLine("1. View Inventory");
                Console.WriteLine("2. Add Item");
                Console.WriteLine("3. Remove Item");
                Console.WriteLine("4. Exit Item");
                Console.WriteLine("Select an Option"); //Prompts the user for input
                string input = Console.ReadLine(); //Read users menu selection

                switch (input) //handles different menu option
                {
                    case "1":
                        break;
                    case "2":
                        AddItem();
                        break;
                    case "3":
                        break;
                    case "4":
                        running = false;
                        break;
                    default:
                        break;

                }
            }

            static void AddItem()
            {
                Console.Clear();
                Console.WriteLine("Enter item name to add"); //prompt for item name
                string item = Console.ReadLine(); //Read item name from user
                inventory.Add(item); //Add item to inventory
                Console.WriteLine($"'{item}'added to inventory"); //confirm addition
            }
        }
    }
}*/

using System;
using System.Collections.Generic;

namespace InventorySystem
{
    class Program
    {
        //Create a list to store inventory items
        static List<string> inventory = new List<string>();
        static void Main(string[] args)
        {
            bool running = true;
            //Run the menu loop until the user exits
            while (running == true)
            {
                //Press 1 View Inventory
                //Press 2 Add Item in Inventory
                //Press 3 Remove Item
                //Press 4 Exit
                Console.WriteLine("=== SIMPLE INVENTORY SYSTEM===");
                Console.WriteLine("1. View Inventory");
                Console.WriteLine("2. Add Item");
                Console.WriteLine("3. Remove Item");
                Console.WriteLine("4. Exit Item");
                Console.WriteLine("Select an Option"); //Prompts the user for input
                string input = Console.ReadLine(); //Read users menu selection

                switch (input) //handles different menu option
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("=== VIEW INVENTORY ===");
                        if (inventory.Count == 0)
                        {
                            Console.WriteLine("Inventory is empty.");
                        }
                        else
                        {
                            for (int i = 0; i < inventory.Count; i++)
                            {
                                Console.WriteLine($"{i + 1}. {inventory[i]}");
                            }
                        }
                        Console.WriteLine("Press Enter to return...");
                        Console.ReadLine();
                        break;
                    case "2":
                        AddItem();
                        break;
                    case "3":
                        Console.Clear();
                        Console.WriteLine("=== REMOVE ITEM ===");
                        if (inventory.Count == 0)
                        {
                            Console.WriteLine("Inventory is empty.");
                        }
                        else
                        {
                            for (int i = 0; i < inventory.Count; i++)
                            {
                                Console.WriteLine($"{i + 1}. {inventory[i]}");
                            }

                            Console.WriteLine("Enter the number of the item to remove:");
                            string inputRemove = Console.ReadLine();
                            int index;
                            if (int.TryParse(inputRemove, out index))
                            {
                                if (index >= 1 && index <= inventory.Count)
                                {
                                    string removedItem = inventory[index - 1];
                                    inventory.RemoveAt(index - 1);
                                    Console.WriteLine($"'{removedItem}' removed from inventory.");
                                }
                                else
                                {
                                    Console.WriteLine("Invalid item number.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Please enter a valid number.");
                            }
                        }
                        Console.WriteLine("Press Enter to return...");
                        Console.ReadLine();
                        break;
                    case "4":
                        running = false;
                        break;
                    default:
                        break;
                }
            }

            static void AddItem()
            {
                Console.Clear();
                Console.WriteLine("Enter item name to add"); //prompt for item name
                string item = Console.ReadLine(); //Read item name from user
                inventory.Add(item); //Add item to inventory
                Console.WriteLine($"'{item}'added to inventory"); //confirm addition
                Console.WriteLine("Press Enter to return...");
                Console.ReadLine();
            }
        }
    }
}