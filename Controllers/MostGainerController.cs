﻿using DMA__Pty__Ltd.Models;
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
    public class MostGainerController : Controller
    {
        // GET: MostGainer
        public ActionResult Index()
        {
            List<MostGainer> mostGainers = new List<MostGainer>();
            HttpWebRequest majorIndexesUrl = (HttpWebRequest)WebRequest.Create("https://financialmodelingprep.com/api/v3/stock/gainers");
            majorIndexesUrl.ContentType = "application/json;";
            HttpWebResponse response = majorIndexesUrl.GetResponse() as HttpWebResponse;
            using (Stream responseStream = response.GetResponseStream())
            {
                StreamReader reader = new StreamReader(responseStream);
                JObject responseobj = JObject.Parse(reader.ReadToEnd());
                JArray items = (JArray)responseobj["mostGainerStock"];
                int total = items.Count();
                for (int i = 0; i < total; i++)
                {
                    JObject results = (JObject)(items)[i];
                    mostGainers.Add(new MostGainer((string)results["ticker"], (string)results["changes"], (string)results["price"], (string)results["changesPercentage"], (string)results["companyName"]));
                }
            }
            return View(mostGainers);
        }
    }
}