using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace DMA__Pty__Ltd.Models
{
    public class CompanyFinancials
    {
        public string date { get; set; }
        [DisplayName("Revenue Growth")]
        public string Revenue { get; set; }
        [DisplayName("Gross Profit")]
        public string RevenueGrowth { get; set; }
        [DisplayName("Cost of Revenue")]
        public string CostOfRevenue { get; set; }
        [DisplayName("Gross Profit")]
        public string GrossProfit { get; set; }
        [DisplayName("R&D Expenses")]
        public string RandDExpenses { get; set; }
        [DisplayName("SG&A Expense")]
        public string SGandAExpense { get; set; }
        [DisplayName("Operating Expenses")]
        public string OperatingExpenses { get; set; }
        [DisplayName("Operating Income")]
        public string OperatingIncome { get; set; }
        [DisplayName("Interest Expense")]
        public string InterestExpense { get; set; }
        [DisplayName("Earnings before Tax")]
        public string EarningsbeforeTax { get; set; }
        [DisplayName("Income Tax Expense")]
        public string IncomeTaxExpense { get; set; }
        [DisplayName("Net Income - Non-Controlling int")]
        public string NetIncomeNonControllingint { get; set; }
        [DisplayName("Net Income - Discontinued ops")]
        public string NetIncomeDiscontinuedops { get; set; }
        [DisplayName("Net Income")]
        public string NetIncome { get; set; }
        [DisplayName("Preferred Dividends")]
        public string PreferredDividends { get; set; }
        [DisplayName("Net Income Com")]
        public string NetIncomeCom { get; set; }
        public string EPS { get; set; }
        [DisplayName("EPS Diluted")]
        public string EPSDiluted { get; set; }
        [DisplayName("Weighted Average Shs Out")]
        public string WeightedAverageShsOut { get; set; }
        [DisplayName("Weighted Average Shs Out (Dil)")]
        public string WeightedAverageShsOutDil { get; set; }
        [DisplayName("Dividend per Share")]
        public string DividendperShare { get; set; }
        [DisplayName("Gross Margin")]
        public string GrossMargin { get; set; }
        [DisplayName("EBITDA Margin")]
        public string EBITDAMargin { get; set; }
        [DisplayName("EBIT Margin")]
        public string EBITMargin { get; set; }
        [DisplayName("Profit Margin")]
        public string ProfitMargin { get; set; }
        [DisplayName("Free Cash Flow margin")]
        public string FreeCashFlowmargin { get; set; }
        public string EBITDA { get; set; }
        public string EBIT { get; set; }
        [DisplayName("Consolidated Income")]
        public string ConsolidatedIncome { get; set; }
        [DisplayName("Earnings Before Tax Margin")]
        public string EarningsBeforeTaxMargin { get; set; }
        [DisplayName("Net Profit Margin")]
        public string NetProfitMargin { get; set; }
    }
}