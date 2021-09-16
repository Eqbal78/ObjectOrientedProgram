using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using System.IO;

namespace ObjectOrientedProgram.JsonInventoryManagement
{
    class Inventorys
    {
        public string Name { get; set; }
        public double Weight { get; set; }
        public double Price { get; set; }

        //Parameterized Constructor
        public Inventorys(string Name, double Weight, double Price)
        {
            this.Name = Name;
            this.Weight = Weight;
            this.Price = Price;
        }
    }

    class InventoryDatas
    {
        public void Data()
        {
            //Display Message
            Console.WriteLine("Welcome to JSON Inventory Data Management");
            Console.WriteLine("=========================================");

            //Display Messsages
            Console.WriteLine("Choose An Option to Perform an Action :");
            Console.WriteLine("Press 1 : Add Details In Inventory ");
            Console.WriteLine("Press 2 : Display Inventory Details ");
            Console.WriteLine("----------------------------------------");
            int userOption = int.Parse(Console.ReadLine());

            switch (userOption)
            {
                case 1: //Add Details
                        //Create List
                    List<Inventorys> inventoryList = new List<Inventorys>();

                    Inventorys inventory = new Inventorys("Rice", 500, 60);
                    Inventorys inventory1 = new Inventorys("Pulses", 300, 80);
                    Inventorys inventory2 = new Inventorys("Wheats", 1000, 100);

                    //Adding to List
                    inventoryList.Add(inventory);
                    inventoryList.Add(inventory1);
                    inventoryList.Add(inventory2);

                    //Serialize JSON 
                    string json = JsonConvert.SerializeObject(inventoryList);
                    File.WriteAllText(@"C:\Users\HP\Desktop\DotNet projects\ObjectOrientedProgram\ObjectOrientedProgram\ObjectOrientedProgram\JsonInventoryManagement\InventoryDetails.json", json);

                    Console.WriteLine("Inventory Details Added SuccessFully in File.");
                    break;

                case 2:// Display Inventory Items

                    //Display Messages
                    Console.WriteLine("Dispaly Inventory Items");
                    Console.WriteLine("-----------------------");

                    //Deserialize Data of JSON file
                    string datafile = File.ReadAllText(@"C:\Users\HP\Desktop\DotNet projects\ObjectOrientedProgram\ObjectOrientedProgram\ObjectOrientedProgram\JsonInventoryManagement\InventoryDetails.json");

                    List<Inventorys> returnDataObj = JsonConvert.DeserializeObject<List<Inventorys>>(datafile);

                    //Display JSON file Data
                    foreach (var form in returnDataObj)
                    {

                        Console.WriteLine("Name : " + form.Name);
                        Console.WriteLine("Weight : " + form.Weight);
                        Console.WriteLine("Price : " + form.Price);

                        //Calulation
                        Console.WriteLine("Total Value of {0} =  {1}: ", form.Name, (form.Weight * form.Price));
                        Console.WriteLine("---------------------------------");
                    }
                    break;

                default:
                    Console.WriteLine("Invalid Input !!!");
                    break;

            }
        }
    }
}
