using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DMA__Pty__Ltd.Models
{
    public class StockChart
    {
        public StockChart(string date, string close)
        {
            this.date = date;
            this.close = close;
        }

        public string date { get; set; }
        public string close { get; set; }
    }
}