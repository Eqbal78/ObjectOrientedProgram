using Newtonsoft.Json;
using System.IO;
using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedProgram.JsonInventory
{
    public class Inventory
    {
        public string Name { get; set; }
        public double Weight { get; set; }
        public double Price { get; set; }

        //Parameterized Constructor
        public Inventory(string Name, double Weight, double Price)
        {
            this.Name = Name;
            this.Weight = Weight;
            this.Price = Price;
        }
    }

    public class InventoryData
    {
        public void Data()
        {
            //Add Details
            //Create List
            List<Inventory> inventoryList = new List<Inventory>();

            Inventory inventory = new Inventory("Rice", 500, 60);
            Inventory inventory1 = new Inventory("Pulses", 300, 80);
            Inventory inventory2 = new Inventory("Wheats", 1000, 100);

            //Adding to List
            inventoryList.Add(inventory);
            inventoryList.Add(inventory1);
            inventoryList.Add(inventory2);

            //WriteFile using Serialize JSON 
            string json = JsonConvert.SerializeObject(inventoryList);
            File.WriteAllText(@"C:\Users\HP\Desktop\DotNet projects\ObjectOrientedProgram\ObjectOrientedProgram\ObjectOrientedProgram\JsonInventory\InventoryDetails.json", json);

            Console.WriteLine("Inventory Details Added SuccessFully in File.");

            // ReadFile using Deserialize Json
            string datafile = File.ReadAllText(@"C:\Users\HP\Desktop\DotNet projects\ObjectOrientedProgram\ObjectOrientedProgram\ObjectOrientedProgram\JsonInventory\InventoryDetails.json");
            List<Inventory> returnDataObj = JsonConvert.DeserializeObject<List<Inventory>>(datafile);

            //Display JSON file Data
            foreach (var form in returnDataObj)
            {

                Console.WriteLine("Name : " + form.Name);
                Console.WriteLine("Weight : " + form.Weight);
                Console.WriteLine("Price : " + form.Price);

                //Calulation
                Console.WriteLine("Total Value of {0} =  {1}: ", form.Name, (form.Weight * form.Price));
            }
        }

        internal void CalculateTotalStockValue()
        {
            throw new NotImplementedException();
        }
    }
}
