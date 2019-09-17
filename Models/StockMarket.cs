using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DMA__Pty__Ltd.Models
{
    public class StockMarket
    {
        public StockMarket()
        { }
        public StockMarket(string sector, string changesPercentage)
        {
            this.sector = sector;
            this.changesPercentage = changesPercentage;
        }

        public string sector { get; set; }
        public string changesPercentage { get; set; }
    }
}