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

namespace DMA__Pty__Ltd.Controllers
{
    [Authorize]
    public class StockChartController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult CompanyStockChart(string symbol)
        {
            dynamic mymodel = new ExpandoObject();
            List<CompanyProfile> companyProfiles = new List<CompanyProfile>();
            HttpWebRequest majorIndexesUrl = (HttpWebRequest)WebRequest.Create("https://financialmodelingprep.com/api/v3/company/profile/" + symbol);
            majorIndexesUrl.ContentType = "application/json;";
            HttpWebResponse response = majorIndexesUrl.GetResponse() as HttpWebResponse;
            using (Stream responseStream = response.GetResponseStream())
            {
                StreamReader reader = new StreamReader(responseStream);
                JObject responseobj = JObject.Parse(reader.ReadToEnd());

                JObject items = (JObject)responseobj["profile"];

                companyProfiles.Add(new CompanyProfile((string)items["price"], (string)items["beta"],
                    (string)items["volAvg"], (string)items["mktCap"], (string)items["lastDiv"],
                    (string)items["range"], (string)items["changes"], (string)items["changesPercentage"],
                    (string)items["companyName"], (string)items["exchange"], (string)items["industry"],
                    (string)items["website"], (string)items["description"], (string)items["ceo"],
                    (string)items["sector"], (string)items["image"])); ;
            }
            mymodel.CompanyProfile = companyProfiles;

            List<StockChart>stockCharts = new List<StockChart>();
            HttpWebRequest stockIndexesUrl = (HttpWebRequest)WebRequest.Create("https://financialmodelingprep.com/api/v3/historical-price-full/" + symbol + "?serietype=line");
            majorIndexesUrl.ContentType = "application/json;";
            HttpWebResponse stockresponse = stockIndexesUrl.GetResponse() as HttpWebResponse;
            using (Stream responseStream = stockresponse.GetResponseStream())
            {
                StreamReader reader = new StreamReader(responseStream);
                JObject responseobj = JObject.Parse(reader.ReadToEnd());

                JArray items = (JArray)responseobj["historical"];
                int total = items.Count();
                for (int i = 0; i < total; i++)
                {
                    JObject results = (JObject)(items)[i];
                    stockCharts.Add(new StockChart((string)results["date"], (string)results["close"]));
                }
                 
            }
            mymodel.StockChart = stockCharts;
            ViewData["StockChart"] = stockCharts;

            return View(mymodel);
        }
    }
}