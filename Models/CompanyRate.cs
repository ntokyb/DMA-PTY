using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DMA__Pty__Ltd.Models
{
    public class CompanyRate
    {
        public class Rating
        {
            public string score { get; set; }
            public string rating { get; set; }
            public string recommendation { get; set; }
        }
        public class RatingDetails
        {
            public string name { get; set; }
            public string score { get; set; }
            public string recommendation { get; set; }
        }
    }
}