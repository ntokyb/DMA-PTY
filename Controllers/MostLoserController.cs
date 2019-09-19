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
    public class MostLoserController : Controller
    {
        [Authorize]
        // GET: MostLoser
        public ActionResult Index()
        {
            List<MostLoser> mostLosers = new List<MostLoser>();
            HttpWebRequest majorIndexesUrl = (HttpWebRequest)WebRequest.Create("https://financialmodelingprep.com/api/v3/stock/losers");
            majorIndexesUrl.ContentType = "application/json;";
            HttpWebResponse response = majorIndexesUrl.GetResponse() as HttpWebResponse;
            using (Stream responseStream = response.GetResponseStream())
            {
                StreamReader reader = new StreamReader(responseStream);
                JObject responseobj = JObject.Parse(reader.ReadToEnd());
                JArray items = (JArray)responseobj["mostLoserStock"];
                int total = items.Count();
                for (int i = 0; i < total; i++)
                {
                    JObject results = (JObject)(items)[i];
                    mostLosers.Add(new MostLoser((string)results["ticker"], (string)results["changes"], (string)results["price"], (string)results["changesPercentage"], (string)results["companyName"]));
                }
            }
            return View(mostLosers);
        }
    }
}