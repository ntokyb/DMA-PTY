using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DMA__Pty__Ltd.Models
{
    public class Market
    {

        public Market(string ticker, string changes, string price, string indexName)
        {
            this.ticker = ticker;
            this.changes = changes;
            this.price = price;
            this.indexName = indexName;
        }

        public string ticker { get; set; }
        public string changes { get; set; }
        public string price { get; set; }
        public string indexName { get; set; }

    }
   
}