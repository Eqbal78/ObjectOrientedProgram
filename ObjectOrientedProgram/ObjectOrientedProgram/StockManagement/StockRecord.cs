using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using System.IO;

namespace ObjectOrientedProgram.StockManagement
{
    class StockManagement
    {

        //Lis is Holding the value of Stocks
        public List<StockRecord> Stocks { get; set; }

        public class StockRecord
        {

            public string Name { get; set; }
            public int Volume { get; set; }
            public int Price { get; set; }

            //Parameterized Constructor
            public StockRecord(string Name, int Volume, int Price)
            {
                this.Name = Name;
                this.Volume = Volume;
                this.Price = Price;
            }
        }

    }


    public class Stock
    {
        //Read Json File 
        StockManagement manage = JsonConvert.DeserializeObject<StockManagement>(File.ReadAllText(@"C:\Users\HP\Desktop\DotNet projects\ObjectOrientedProgram\ObjectOrientedProgram\ObjectOrientedProgram\StockManagement\StockReports.json"));

        //Printing Stock Report
        public void Stock_Management()
        {

            Console.WriteLine("--------------------Dispaly Stock Report---------------------");
            foreach (StockManagement.StockRecord stock in manage.Stocks)
            {
                Console.WriteLine("Name of the stock : " + stock.Name);
                Console.WriteLine("Total stocks of a company : " + stock.Volume);
                Console.WriteLine("Stock Price : " + stock.Price + "\n");

            }
        }

        //Calculating each stock value
        public void CalculateEachStockValue()
        {
            double value = 0, price = 0;
            int numOfShare = 0;
            Console.WriteLine("-----------------------Calculate each stock value-----------------------");
            for (int i = 0; i < manage.Stocks.Count; i++)
            {
                var jsonObject = manage.Stocks[i];
                price = jsonObject.Price;
                numOfShare = jsonObject.Volume;
                value = price * numOfShare;
                Console.WriteLine("Value of the particular stock for " + jsonObject.Name + " is " + value + "\n");
            }
        }

        //Calculating total stock value
        public void CalculateTotalStockValue()
        {
            double value = 0, price = 0, totalValue = 0;
            int numOfShare = 0;
            Console.WriteLine("\n-----------------------Calculate total stock value-----------------------");
            for (int i = 0; i < manage.Stocks.Count; i++)
            {
                var jsonObject = manage.Stocks[i];
                price = jsonObject.Price;
                numOfShare = jsonObject.Volume;
                value = price * numOfShare;
                totalValue += value;
            }
            Console.WriteLine("Value of the Total stock is " + totalValue + "\n");
        }

    }
}
