using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DMA__Pty__Ltd.Models
{
    public class MarketsApiViewModel
    {
        public List<Market> GetMarkets { get; set; }
        public List<StockMarket> GetStocks { get; set; }
    }
}