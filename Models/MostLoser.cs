using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DMA__Pty__Ltd.Models
{
    public class MostLoser
    {
        public MostLoser(string ticker, string changes, string price, string changesPercentage, string companyName)
        {
            this.ticker = ticker;
            this.changes = changes;
            this.price = price;
            this.changesPercentage = changesPercentage;
            this.companyName = companyName;
        }

        public string ticker { get; set; }
        public string changes { get; set; }
        public string price { get; set; }
        public string changesPercentage { get; set; }
        public string companyName { get; set; }
    }
}