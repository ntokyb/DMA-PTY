using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DMA__Pty__Ltd.Models
{
    public class CompanyFinancialGrowth
    {
        public CompanyFinancialGrowth(string date, string grossProfitGrowth, string eBITGrowth, string operatingIncomeGrowth, string netIncomeGrowth, string ePSGrowth, string ePSDilutedGrowth, string weightedAverageSharesGrowth, string weightedAverageSharesDilutedGrowth, string dividendsperShareGrowth, string operatingCashFlowgrowth, string freeCashFlowgrowth, string tenYRevenueGrowthperShare, string fiveYRevenueGrowthperShare, string threeYRevenueGrowthperShare, string tenYOperatingCFGrowthperShare, string fiveYOperatingCFGrowthperShare, string threeYOperatingCFGrowthperShare, string tenYNetIncomeGrowthperShare, string fiveYNetIncomeGrowthperShare, string threeYNetIncomeGrowthperShare, string tenYShareholdersEquityGrowthperShare, string fiveYShareholdersEquityGrowthperShare, string threeYShareholdersEquityGrowthperShare, string tenYDividendperShareGrowthperShare, string fiveYDividendperShareGrowthperShare, string threeYDividendperShareGrowthperShare, string receivablesgrowth, string inventoryGrowth, string assetGrowth, string bookValueperShareGrowth, string debtGrowth, string rNDExpenseGrowth, string sGNAExpensesGrowth)
        {
            this.date = date;
            GrossProfitGrowth = grossProfitGrowth;
            EBITGrowth = eBITGrowth;
            OperatingIncomeGrowth = operatingIncomeGrowth;
            NetIncomeGrowth = netIncomeGrowth;
            EPSGrowth = ePSGrowth;
            EPSDilutedGrowth = ePSDilutedGrowth;
            WeightedAverageSharesGrowth = weightedAverageSharesGrowth;
            WeightedAverageSharesDilutedGrowth = weightedAverageSharesDilutedGrowth;
            DividendsperShareGrowth = dividendsperShareGrowth;
            OperatingCashFlowgrowth = operatingCashFlowgrowth;
            FreeCashFlowgrowth = freeCashFlowgrowth;
            this.tenYRevenueGrowthperShare = tenYRevenueGrowthperShare;
            this.fiveYRevenueGrowthperShare = fiveYRevenueGrowthperShare;
            this.threeYRevenueGrowthperShare = threeYRevenueGrowthperShare;
            this.tenYOperatingCFGrowthperShare = tenYOperatingCFGrowthperShare;
            this.fiveYOperatingCFGrowthperShare = fiveYOperatingCFGrowthperShare;
            this.threeYOperatingCFGrowthperShare = threeYOperatingCFGrowthperShare;
            this.tenYNetIncomeGrowthperShare = tenYNetIncomeGrowthperShare;
            this.fiveYNetIncomeGrowthperShare = fiveYNetIncomeGrowthperShare;
            this.threeYNetIncomeGrowthperShare = threeYNetIncomeGrowthperShare;
            this.tenYShareholdersEquityGrowthperShare = tenYShareholdersEquityGrowthperShare;
            this.fiveYShareholdersEquityGrowthperShare = fiveYShareholdersEquityGrowthperShare;
            this.threeYShareholdersEquityGrowthperShare = threeYShareholdersEquityGrowthperShare;
            this.tenYDividendperShareGrowthperShare = tenYDividendperShareGrowthperShare;
            this.fiveYDividendperShareGrowthperShare = fiveYDividendperShareGrowthperShare;
            this.threeYDividendperShareGrowthperShare = threeYDividendperShareGrowthperShare;
            Receivablesgrowth = receivablesgrowth;
            InventoryGrowth = inventoryGrowth;
            AssetGrowth = assetGrowth;
            BookValueperShareGrowth = bookValueperShareGrowth;
            DebtGrowth = debtGrowth;
            RNDExpenseGrowth = rNDExpenseGrowth;
            SGNAExpensesGrowth = sGNAExpensesGrowth;
        }

        public string date { get; set; }
        public string GrossProfitGrowth { get; set; }
        public string EBITGrowth { get; set; }
        public string OperatingIncomeGrowth { get; set; }
        public string NetIncomeGrowth { get; set; }
        public string EPSGrowth { get; set; }
        public string EPSDilutedGrowth { get; set; }
        public string WeightedAverageSharesGrowth { get; set; }
        public string WeightedAverageSharesDilutedGrowth { get; set; }
        public string DividendsperShareGrowth { get; set; }
        public string OperatingCashFlowgrowth { get; set; }
        public string FreeCashFlowgrowth { get; set; }
        public string tenYRevenueGrowthperShare { get; set; }
        public string fiveYRevenueGrowthperShare { get; set; }
        public string threeYRevenueGrowthperShare { get; set; }
        public string tenYOperatingCFGrowthperShare { get; set; }
        public string fiveYOperatingCFGrowthperShare { get; set; }
        public string threeYOperatingCFGrowthperShare { get; set; }
        public string tenYNetIncomeGrowthperShare { get; set; }
        public string fiveYNetIncomeGrowthperShare { get; set; }
        public string threeYNetIncomeGrowthperShare { get; set; }
        public string tenYShareholdersEquityGrowthperShare { get; set; }
        public string fiveYShareholdersEquityGrowthperShare { get; set; }
        public string threeYShareholdersEquityGrowthperShare { get; set; }
        public string tenYDividendperShareGrowthperShare { get; set; }
        public string fiveYDividendperShareGrowthperShare { get; set; }
        public string threeYDividendperShareGrowthperShare { get; set; }
        public string Receivablesgrowth { get; set; }
        public string InventoryGrowth { get; set; }
        public string AssetGrowth { get; set; }
        public string BookValueperShareGrowth { get; set; }
        public string DebtGrowth { get; set; }
        public string RNDExpenseGrowth { get; set; }
        public string SGNAExpensesGrowth { get; set; }
    }
}