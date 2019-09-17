using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace DMA__Pty__Ltd.Models
{
    public class CompanyProfile
    {
        public CompanyProfile(string price, string beta, string volAvg, string mktCap, string lastDiv, string range, string changes, string changesPercentage, string companyName, string exchange, string industry, string website, string description, string ceo, string sector, string image)
        {
            this.price = price;
            this.beta = beta;
            this.volAvg = volAvg;
            this.mktCap = mktCap;
            this.lastDiv = lastDiv;
            this.range = range;
            this.changes = changes;
            this.changesPercentage = changesPercentage;
            this.companyName = companyName;
            this.exchange = exchange;
            this.industry = industry;
            this.website = website;
            this.description = description;
            this.ceo = ceo;
            this.sector = sector;
            this.image = image;
        }

        public string price { get; set; }
        public string beta { get; set; }
        public string volAvg { get; set; }
        public string mktCap { get; set; }
        public string lastDiv { get; set; }
        public string range { get; set; }
        public string changes { get; set; }
        public string changesPercentage { get; set; }
        public string companyName { get; set; }
        public string exchange { get; set; }
        public string industry { get; set; }
        public string website { get; set; }
        public string description { get; set; }
        public string ceo { get; set; }
        public string sector { get; set; }
        public string image { get; set; }
    }
}