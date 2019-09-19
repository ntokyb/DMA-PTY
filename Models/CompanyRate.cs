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
            public Rating(string score, string rating, string recommendation)
            {
                this.score = score;
                this.rating = rating;
                this.recommendation = recommendation;
            }

            public string score { get; set; }
            public string rating { get; set; }
            public string recommendation { get; set; }
        }
        public class RatingDetails
        {
            public RatingDetails(string score, string recommendation)
            {
                this.score = score;
                this.recommendation = recommendation;
            }

            public string score { get; set; }
            public string recommendation { get; set; }
        }
    }
}