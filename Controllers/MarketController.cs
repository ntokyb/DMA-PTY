using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Threading.Tasks;
using DMA__Pty__Ltd.Models;
using Newtonsoft.Json.Linq;
using System.Net;
using System.IO;

namespace DMA__Pty__Ltd.Controllers
{
    [Authorize]
    public class MarketController : Controller
    {
        // GET: Market
        public ActionResult Index()
        {
            //StockMarket();
            MarketIndexes();
            return View();
        }
        public PartialViewResult MarketIndexes()
        {
            
            List<Market> markets = new List<Market>();
            HttpWebRequest majorIndexesUrl = (HttpWebRequest)WebRequest.Create("https://financialmodelingprep.com/api/v3/majors-indexes");
            majorIndexesUrl.ContentType = "application/json;";
            HttpWebResponse response =  majorIndexesUrl.GetResponse() as HttpWebResponse;
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
            return PartialView("_MarketIndexes", markets);
        }
        
    }
}