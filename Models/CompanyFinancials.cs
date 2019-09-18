using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace DMA__Pty__Ltd.Models
{
    public class CompanyFinancials
    {
        public CompanyFinancials(string date, string revenue, string revenueGrowth, string costOfRevenue, string grossProfit, string randDExpenses, string sGandAExpense, string operatingExpenses, string operatingIncome, string interestExpense, string earningsbeforeTax, string incomeTaxExpense, string netIncomeNonControllingint, string netIncomeDiscontinuedops, string netIncome, string preferredDividends, string netIncomeCom, string ePS, string ePSDiluted, string weightedAverageShsOut, string weightedAverageShsOutDil, string dividendperShare, string grossMargin, string eBITDAMargin, string eBITMargin, string profitMargin, string freeCashFlowmargin, string eBITDA, string eBIT, string consolidatedIncome, string earningsBeforeTaxMargin, string netProfitMargin)
        {
            this.date = date;
            Revenue = revenue;
            RevenueGrowth = revenueGrowth;
            CostOfRevenue = costOfRevenue;
            GrossProfit = grossProfit;
            RandDExpenses = randDExpenses;
            SGandAExpense = sGandAExpense;
            OperatingExpenses = operatingExpenses;
            OperatingIncome = operatingIncome;
            InterestExpense = interestExpense;
            EarningsbeforeTax = earningsbeforeTax;
            IncomeTaxExpense = incomeTaxExpense;
            NetIncomeNonControllingint = netIncomeNonControllingint;
            NetIncomeDiscontinuedops = netIncomeDiscontinuedops;
            NetIncome = netIncome;
            PreferredDividends = preferredDividends;
            NetIncomeCom = netIncomeCom;
            EPS = ePS;
            EPSDiluted = ePSDiluted;
            WeightedAverageShsOut = weightedAverageShsOut;
            WeightedAverageShsOutDil = weightedAverageShsOutDil;
            DividendperShare = dividendperShare;
            GrossMargin = grossMargin;
            EBITDAMargin = eBITDAMargin;
            EBITMargin = eBITMargin;
            ProfitMargin = profitMargin;
            FreeCashFlowmargin = freeCashFlowmargin;
            EBITDA = eBITDA;
            EBIT = eBIT;
            ConsolidatedIncome = consolidatedIncome;
            EarningsBeforeTaxMargin = earningsBeforeTaxMargin;
            NetProfitMargin = netProfitMargin;
        }

        public string date { get; set; }
        public string Revenue { get; set; }
        public string RevenueGrowth { get; set; }
        public string CostOfRevenue { get; set; }
        public string GrossProfit { get; set; }
        public string RandDExpenses { get; set; }
        public string SGandAExpense { get; set; }
        public string OperatingExpenses { get; set; }
        public string OperatingIncome { get; set; }
        public string InterestExpense { get; set; }
        public string EarningsbeforeTax { get; set; }
        public string IncomeTaxExpense { get; set; }
        public string NetIncomeNonControllingint { get; set; }
        public string NetIncomeDiscontinuedops { get; set; }
        public string NetIncome { get; set; }
        public string PreferredDividends { get; set; }
        public string NetIncomeCom { get; set; }
        public string EPS { get; set; }
        public string EPSDiluted { get; set; }
        public string WeightedAverageShsOut { get; set; }
        public string WeightedAverageShsOutDil { get; set; }
        public string DividendperShare { get; set; }
        public string GrossMargin { get; set; }
        public string EBITDAMargin { get; set; }
        public string EBITMargin { get; set; }
        public string ProfitMargin { get; set; }
        public string FreeCashFlowmargin { get; set; }
        public string EBITDA { get; set; }
        public string EBIT { get; set; }
        public string ConsolidatedIncome { get; set; }
        public string EarningsBeforeTaxMargin { get; set; }
        public string NetProfitMargin { get; set; }
    }
}