﻿using ObjectOrientedProgram.JsonInventory;
using ObjectOrientedProgram.JsonInventoryManagement;
using ObjectOrientedProgram.StockManagement;
using ObjectOrientedProgram.StockDataProcessing;
using System;
using Newtonsoft.Json;
using System.IO;


namespace ObjectOrientedProgram.StockDataProcessing
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcom to Object Oriented Programs\n");
            
            while (true)
            {
                Console.WriteLine("\nChoose An Option to Perform an Action :");
                Console.WriteLine("Press 1 : Json Inventory \nPress 2 : Json Inventory Management\nPress 3 : Stock Management\nPress 4 : Stock Data Processing \nPress 5 : Exit");
                Console.WriteLine("----------------------------------------");
                int userOption = int.Parse(Console.ReadLine());
                switch (userOption)
                {
                    case 1:
                        Console.WriteLine("Display Json Inventory\n");
                        InventoryData obj = new InventoryData();
                        obj.Data();
                        break;

                    case 2:
                        Console.WriteLine("Display Json Inventory Management\n");
                        InventoryDatas a = new InventoryDatas();
                        a.Data();
                        break;

                    case 3:
                        Console.WriteLine("Display Stock Management\n");
                        Stock b = new Stock();
                        b.Stock_Management();
                        b.CalculateEachStockValue();
                        b.CalculateTotalStockValue();
                        break;

                    case 4:
                        Console.WriteLine("Display Stock Data Processing\n");
                        StockManagement c = new StockManagement();
                        c.Choose();
                        break;

                    case 5:
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("You Enter an Invalid Number:\n");
                        break;
                       

                }
    
            }
        }
            
    }
}
