using System;
namespace playground
{
    public class LemonadeStand
    {
        public string Name { get; set; }
        public decimal TableCost { get; set; }
        public decimal ChairCost { get; set; }
        public decimal SignCost { get; set; }
        public decimal LemonsCostPerCup { get; set; }
        public decimal SugarCostPerCup { get; set; }
        public decimal PricePerCup { get; set; }
        public int NumberOfCupsSold { get; set; }

        public decimal GetTotalRevenue()
        {
            return NumberOfCupsSold * PricePerCup;
        }
        public decimal GetTotalExpenses()
        {
            decimal fixedCosts = TableCost + ChairCost + SignCost;
            decimal variableCosts = (LemonsCostPerCup + SugarCostPerCup + SugarCostPerCup) * NumberOfCupsSold;
            return fixedCosts + variableCosts;
        }
        public decimal GetTotalProfit()
        {
            return GetTotalRevenue() - GetTotalExpenses();
        }
    }
}
