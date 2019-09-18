using DMA__Pty__Ltd.Models;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace DMA__Pty__Ltd.Controllers
{
    [Authorize]
    public class StockMarketController : Controller
    {
        // GET: StockMarket
        public ActionResult Index()
        {
            StockMarket();
            return View();
        }
        public PartialViewResult StockMarket()
        {
            List<StockMarket> stockMarkets = new List<StockMarket>();
            HttpWebRequest majorIndexesUrl = (HttpWebRequest)WebRequest.Create("https://financialmodelingprep.com/api/v3/stock/sectors-performance");
            majorIndexesUrl.ContentType = "application/json;";
            HttpWebResponse response = majorIndexesUrl.GetResponse() as HttpWebResponse;
            using (Stream responseStream = response.GetResponseStream())
            {
                StreamReader reader = new StreamReader(responseStream);
                JObject responseobj = JObject.Parse(reader.ReadToEnd());
                JArray items = (JArray)responseobj["sectorPerformance"];
                int total = items.Count();
                for (int i = 0; i < total; i++)
                {
                    JObject results = (JObject)(items)[i];
                    stockMarkets.Add(new StockMarket((string)results["sector"], (string)results["changesPercentage"]));
                }
            }
            return PartialView("_StockMarket", stockMarkets);
        }
    }
}