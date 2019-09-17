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

        public ActionResult CompanyInfomation(string symbol)
        {
            List<CompanyProfile> companyProfiles = new List<CompanyProfile>();
            HttpWebRequest majorIndexesUrl = (HttpWebRequest)WebRequest.Create("https://financialmodelingprep.com/api/v3/company/profile/"+ symbol);
            majorIndexesUrl.ContentType = "application/json;";
            HttpWebResponse response = majorIndexesUrl.GetResponse() as HttpWebResponse;
            using (Stream responseStream = response.GetResponseStream())
            {
                StreamReader reader = new StreamReader(responseStream);
                JObject responseobj = JObject.Parse(reader.ReadToEnd());
                JArray items = (JArray)responseobj["profile"];
                int total = items.Count();
                for (int i = 0; i < total; i++)
                {
                    JObject results = (JObject)(items)[i];
                    companyProfiles.Add(new CompanyProfile((string)results["price"],(string)results["beta"],
                        (string)results["volAvg"],(string)results["mktCap"],(string)results["lastDiv"],
                        (string)results["range"],(string)results["changes"],(string)results["changesPercentage"],
                        (string)results["companyName"],(string)results["exchange"],(string)results["industry"],
                        (string)results["website"],(string)results["description"],(string)results["ceo"],
                        (string)results["sector"],(string)results["image"])); ;
                }
            }
            return View(companyProfiles);
        }
    }
}