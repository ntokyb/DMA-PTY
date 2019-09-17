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
    public class MarketPageController : Controller
    {
        // GET: MarketPage
        public ActionResult Index()
        {
            var model = new MarketsApiViewModel();

            List<Market> markets = new List<Market>();
            HttpWebRequest majorIndexesUrl = (HttpWebRequest)WebRequest.Create("https://financialmodelingprep.com/api/v3/majors-indexes");
            majorIndexesUrl.ContentType = "application/json;";
            HttpWebResponse response = majorIndexesUrl.GetResponse() as HttpWebResponse;
            using (Stream responseStream = response.GetResponseStream())
            {
                StreamReader reader = new StreamReader(responseStream);
                JObject responseobj = JObject.Parse(reader.ReadToEnd());
                JArray items = (JArray)responseobj["majorIndexesList"];
                int total = items.Count();
                for (int i = 0; i < total; i++)
                {
                    JObject results = (JObject)(items)[i];
                    markets.Add(new Market((string)results["ticker"], (string)results["changes"], (string)results["price"], (string)results["indexName"]));
                }
            }
            model.GetMarkets = markets;

            List<StockMarket> stockMarkets = new List<StockMarket>();
            HttpWebRequest stockUrl = (HttpWebRequest)WebRequest.Create("https://financialmodelingprep.com/api/v3/stock/sectors-performance");
            stockUrl.ContentType = "application/json;";
            HttpWebResponse stockresponse = stockUrl.GetResponse() as HttpWebResponse;
            using (Stream responseStream = stockresponse.GetResponseStream())
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
            model.GetStocks = stockMarkets;

            return View(model);
        }

    }
}