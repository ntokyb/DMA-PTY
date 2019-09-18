using DMA__Pty__Ltd.Models;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using X.PagedList;

namespace DMA__Pty__Ltd.Controllers
{
    //[Authorize]
	public class HomeController : Controller
	{
        [HttpGet]
		public ActionResult Index(int? page)
		{
            dynamic mymodel = new ExpandoObject();
            int pageSize = 5;
            int pageIndex = 1;
            pageIndex = page.HasValue ? Convert.ToInt32(page) : 1;
            int totalCount = 0;
            int pagenumber = (page ?? 1) - 1;

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
            IPagedList<Market> makrketOrders = new StaticPagedList<Market>(markets, pagenumber + 1, 5, totalCount);
            mymodel.Market = makrketOrders;


            List<StockMarket> stockMarkets = new List<StockMarket>();
            HttpWebRequest stockUrl = (HttpWebRequest)WebRequest.Create("https://financialmodelingprep.com/api/v3/stock/sectors-performance");
            stockUrl.ContentType = "application/json;";
            HttpWebResponse responses = stockUrl.GetResponse() as HttpWebResponse;
            using (Stream responseStream = responses.GetResponseStream())
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
            mymodel.StockMarket = stockMarkets;
            return View(mymodel);
		}

		public ActionResult About()
		{
			ViewBag.Message = "Your application description page.";

			return View();
		}

		public ActionResult Contact()
		{
			ViewBag.Message = "Your contact page.";

			return View();
		}
        
    }
}