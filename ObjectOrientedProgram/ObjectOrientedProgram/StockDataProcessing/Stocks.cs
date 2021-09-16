using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedProgram.StockDataProcessing
{
    class Stocks
    {
        public List<StockRecords> StockRecordsList { get; set; }
        public class StockRecords
        {
            public string Symbol { get; set; }
            public int NumberOfShares { get; set; }
            public string DateTime { get; set; }
            public int StockValue { get; set; }
            public int StockPrice { get; set; }
        }
    }
}
