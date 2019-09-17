using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DMA__Pty__Ltd.Models
{
    public class Symbol
    {
        public Symbol(string symbol, string name)
        {
            this.symbol = symbol;
            this.name = name;
        }

        public string symbol { get; set; }
        public string name { get; set; }
    }
}