using System;
namespace playground
{
    public class LemonadeStand
    {
        public LemonadeStand(string name)
        {
            if (name == null)
            {
                Name = "";
            }
            else
            {
                Name = name;
            }
        }
        public string Name { get; set; }
        public decimal PricePerCup { get; set; }
        public decimal CostPerCup { get; set; }
        public int NumberOfCUpsSold { get; set; }

        public decimal GetTotalProfit()
        {
            return (PricePerCup - CostPerCup) * NumberOfCUpsSold;
        }
    }
}
