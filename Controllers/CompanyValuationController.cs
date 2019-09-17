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
    public class CompanyValuationController : Controller
    {
        // GET: CompanyValuation
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult CompanyInfomation()
        {
            List<Symbol> symbols = new List<Symbol>();
            HttpWebRequest majorIndexesUrl = (HttpWebRequest)WebRequest.Create("https://financialmodelingprep.com/api/v3/financials/income-statement/");
            majorIndexesUrl.ContentType = "application/json;";
            HttpWebResponse response = majorIndexesUrl.GetResponse() as HttpWebResponse;
            using (Stream responseStream = response.GetResponseStream())
            {
                StreamReader reader = new StreamReader(responseStream);
                JObject responseobj = JObject.Parse(reader.ReadToEnd());
                JArray items = (JArray)responseobj["symbolsList"];
                int total = items.Count();
                for (int i = 0; i < total; i++)
                {
                    JObject results = (JObject)(items)[i];
                    symbols.Add(new Symbol((string)results["symbol"], (string)results["name"]));
                }
            }
        }
    }
}