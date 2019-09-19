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
    //[Authorize]
    public class CompanyValuationController : Controller
    {
        // GET: CompanyValuation
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CompanyInfomation(string symbol)
        {
            dynamic mymodel = new ExpandoObject();
            List<CompanyProfile> companyProfiles = new List<CompanyProfile>();
            HttpWebRequest majorIndexesUrl = (HttpWebRequest)WebRequest.Create("https://financialmodelingprep.com/api/v3/company/profile/"+ symbol);
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

            List<CompanyFinancials> companyFinancials = new List<CompanyFinancials>();
            HttpWebRequest financeIndexesUrl = (HttpWebRequest)WebRequest.Create("https://financialmodelingprep.com/api/v3/financials/income-statement/" + symbol);
            financeIndexesUrl.ContentType = "application/json;";
            HttpWebResponse financeresponse = financeIndexesUrl.GetResponse() as HttpWebResponse;
            using (Stream responseStream = financeresponse.GetResponseStream())
            {
                StreamReader reader = new StreamReader(responseStream);
                JObject responseobj = JObject.Parse(reader.ReadToEnd());
                
                JArray items = (JArray)responseobj["financials"];
                if (items == null)
                {
                    mymodel.CompanyFinancials = companyFinancials;
                    
                }
                else {
                    int total = items.Count();
                    for (int i = 0; i < total; i++)
                    {
                        JObject results = (JObject)(items)[i];
                        companyFinancials.Add(new CompanyFinancials(results["date"].ToString(), results["Revenue"].ToString(),
                            (string)results["Revenue Growth"], (string)results["Cost of Revenue"], (string)results["Gross Profit"],
                            (string)results["R&D Expenses"], (string)results["SG&A Expense"], (string)results["Operating Expenses"],
                            (string)results["Operating Income"], (string)results["Interest Expense"], (string)results["Earnings before Tax"],
                            (string)results["Income Tax Expense"], (string)results["Net Income - Non-Controlling int"], (string)results["Net Income - Discontinued ops"],
                            (string)results["Net Income"], (string)results["Preferred Dividends"], (string)results["Net Income Com"],
                            (string)results["EPS"], (string)results["EPS Diluted"], (string)results["Weighted Average Shs Out"],
                            (string)results["Weighted Average Shs Out (Dil)"], (string)results["Dividend per Share"], (string)results["Gross Margin"],
                            (string)results["EBITDA Margin"], (string)results["EBIT Margin"], (string)results["Profit Margin"],
                            (string)results["Free Cash Flow margin"], (string)results["EBITDA"], (string)results["EBIT"],
                            (string)results["Consolidated Income"], (string)results["Earnings Before Tax Margin"], (string)results["Net Profit Margin"]));
                    }
                }
                mymodel.CompanyFinancials = companyFinancials;
            }
           

            List<CompanyFinancialGrowth> companyFinancialGrowths = new List<CompanyFinancialGrowth>();
            HttpWebRequest financeGrowthIndexesUrl = (HttpWebRequest)WebRequest.Create("https://financialmodelingprep.com/api/v3/financial-statement-growth/" + symbol);
            financeIndexesUrl.ContentType = "application/json;";
            HttpWebResponse financegrowthresponse = financeGrowthIndexesUrl.GetResponse() as HttpWebResponse;
            using (Stream responseStream = financegrowthresponse.GetResponseStream())
            {
                StreamReader reader = new StreamReader(responseStream);
                JObject responseobj = JObject.Parse(reader.ReadToEnd());
                
                JArray items = (JArray)responseobj["growth"];
                if (items == null)
                {
                    mymodel.CompanyFinancials = companyFinancialGrowths;

                }
                else {
                    int total = items.Count();
                    for (int i = 0; i < total; i++)
                    {
                        JObject results = (JObject)(items)[i];
                        companyFinancialGrowths.Add(new CompanyFinancialGrowth(results["date"].ToString(), results["Gross Profit Growth"].ToString(),
                            (string)results["EBIT Growth"], (string)results["Operating Income Growth"], (string)results["Net Income Growth"],
                            (string)results["EPS Growth"], (string)results["EPS Diluted Growth"], (string)results["Weighted Average Shares Growth"],
                            (string)results["Weighted Average Shares Diluted Growth"], (string)results["Dividends per Share Growth"], (string)results["Operating Cash Flow growth"],
                            (string)results["Free Cash Flow growth"], (string)results["10Y Revenue Growth (per Share)"], (string)results["5Y Revenue Growth (per Share)"],
                            (string)results["3Y Revenue Growth (per Share)"], (string)results["10Y Operating CF Growth (per Share)"], (string)results["5Y Operating CF Growth (per Share)"],
                            (string)results["3Y Operating CF Growth (per Share)"], (string)results["10Y Net Income Growth (per Share)"], (string)results["5Y Net Income Growth (per Share)"],
                            (string)results["3Y Net Income Growth (per Share)"], (string)results["10Y Shareholders Equity Growth (per Share)"], (string)results["5Y Shareholders Equity Growth (per Share)"],
                            (string)results["3Y Shareholders Equity Growth (per Share)"], (string)results["10Y Dividend per Share Growth (per Share)"], (string)results["5Y Dividend per Share Growth (per Share)"],
                            (string)results["3Y Dividend per Share Growth (per Share)"], (string)results["Receivables growth"], (string)results["Inventory Growth"],
                            (string)results["Asset Growth"], (string)results["Book Value per Share Growth"], (string)results["Debt Growth"],
                            (string)results["R&D Expense Growth"], (string)results["SG&A Expenses Growth"]));
                    }
                }
                mymodel.CompanyFinancialGrowth = companyFinancialGrowths;
            }
            List<CompanyRate.Rating> companyRates = new List<CompanyRate.Rating>();
            List<CompanyRate.RatingDetails> companyRatesDetails = new List<CompanyRate.RatingDetails>();
            List<CompanyRate.RatingDetails> companyRatesDetails1 = new List<CompanyRate.RatingDetails>();
            List<CompanyRate.RatingDetails> companyRatesDetails2 = new List<CompanyRate.RatingDetails>();
            List<CompanyRate.RatingDetails> companyRatesDetails3 = new List<CompanyRate.RatingDetails>();
            List<CompanyRate.RatingDetails> companyRatesDetails4 = new List<CompanyRate.RatingDetails>();
            List<CompanyRate.RatingDetails> companyRatesDetails5 = new List<CompanyRate.RatingDetails>();
            HttpWebRequest rateIndexesUrl = (HttpWebRequest)WebRequest.Create("https://financialmodelingprep.com/api/v3/company/rating/" + symbol);
            financeIndexesUrl.ContentType = "application/json;";
            HttpWebResponse rateresponse = rateIndexesUrl.GetResponse() as HttpWebResponse;
            using (Stream responseStream = rateresponse.GetResponseStream())
            {
                StreamReader reader = new StreamReader(responseStream);
                JObject responseobj = JObject.Parse(reader.ReadToEnd());
               
                

                JObject items = (JObject)responseobj["rating"];
                JObject itemss = (JObject)responseobj["ratingDetails"];
                if (items == null & itemss == null)
                {
                    mymodel.CompanyRate = companyRates;
                }
                else {
                    JObject pb = (JObject)itemss["P/B"];
                    JObject ROA = (JObject)itemss["ROA"];
                    JObject DCF = (JObject)itemss["DCF"];
                    JObject pe = (JObject)itemss["P/E"];
                    JObject ROE = (JObject)itemss["ROE"];
                    JObject de = (JObject)itemss["D/E"];
                    companyRates.Add(new CompanyRate.Rating((string)items["score"], (string)items["rating"], (string)items["recommendation"]));
                    companyRatesDetails.Add(new CompanyRate.RatingDetails((string)pb["score"], (string)pb["recommendation"]));
                    companyRatesDetails1.Add(new CompanyRate.RatingDetails((string)ROA["score"], (string)ROA["recommendation"]));
                    companyRatesDetails2.Add(new CompanyRate.RatingDetails((string)DCF["score"], (string)DCF["recommendation"]));
                    companyRatesDetails3.Add(new CompanyRate.RatingDetails((string)pe["score"], (string)pe["recommendation"]));
                    companyRatesDetails4.Add(new CompanyRate.RatingDetails((string)ROE["score"], (string)ROE["recommendation"]));
                    companyRatesDetails5.Add(new CompanyRate.RatingDetails((string)de["score"], (string)de["recommendation"]));
                }
                mymodel.CompanyRateRating = companyRates;
                mymodel.CompanyRateRatingDetails = companyRatesDetails;
                mymodel.CompanyRateRatingDetails1 = companyRatesDetails1;
                mymodel.CompanyRateRatingDetails2 = companyRatesDetails2;
                mymodel.CompanyRateRatingDetails3 = companyRatesDetails3;
                mymodel.CompanyRateRatingDetails4 = companyRatesDetails4;
                mymodel.CompanyRateRatingDetails5 = companyRatesDetails5;
            }
            

            List<StockChart> stockCharts = new List<StockChart>();
            HttpWebRequest stockIndexesUrl = (HttpWebRequest)WebRequest.Create("https://financialmodelingprep.com/api/v3/historical-price-full/" + symbol + "?serietype=line");
            majorIndexesUrl.ContentType = "application/json;";
            HttpWebResponse stockresponse = stockIndexesUrl.GetResponse() as HttpWebResponse;
            using (Stream responseStream = stockresponse.GetResponseStream())
            {
                StreamReader reader = new StreamReader(responseStream);
                JObject responseobj = JObject.Parse(reader.ReadToEnd());

                JArray items = (JArray)responseobj["historical"];
                if (items == null)
                {
                    mymodel.StockChart = stockCharts;
                }
                else
                {
                    int total = items.Count();
                    for (int i = 0; i < total; i++)
                    {
                        JObject results = (JObject)(items)[i];
                        stockCharts.Add(new StockChart((string)results["date"], (string)results["close"]));
                    }
                }
                mymodel.StockChart = stockCharts;
                ViewData["StockChart"] = stockCharts;
            }
           

            return View("CompanyValuation", mymodel);
        }
    }
}