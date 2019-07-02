using System;

namespace playground

{
    class Program
    {
        static decimal GetDecimalAnswerFromUser(string question)
        {
            Console.WriteLine(question);
            string response = Console.ReadLine();
            decimal answer = decimal.Parse(response);
            return answer;
        }

        static void Main(string[] args)
        {
            LemonadeStand stand = new LemonadeStand();

            Console.WriteLine("What is the name of this lemondade stand?");
            stand.Name = Console.ReadLine();

            stand.TableCost = GetDecimalAnswerFromUser("How much will your table cost?");
            stand.ChairCost = GetDecimalAnswerFromUser("How much will your chair cost?");
            stand.SignCost = GetDecimalAnswerFromUser("How much will your sign cost?");
            stand.LemonsCostPerCup = GetDecimalAnswerFromUser("How much will the lemons cost per cup?");
            stand.SugarCostPerCup = GetDecimalAnswerFromUser("How much will the sugar cost per cup?");
            stand.PricePerCup = GetDecimalAnswerFromUser("What will be the price of a cup?");

            Console.WriteLine("How many cups will you sell?");
            string numberOfCupsResponse = Console.ReadLine();
            stand.NumberOfCupsSold = int.Parse(numberOfCupsResponse);

            decimal totalFixedCosts = stand.TableCost + stand.ChairCost + stand.SignCost;
            decimal totalVariableCost = (stand.LemonsCostPerCup + stand.SugarCostPerCup) * stand.NumberOfCupsSold;
            decimal totalRevenue = stand.PricePerCup * stand.NumberOfCupsSold;

            decimal totalProfit = totalRevenue - totalVariableCost - totalFixedCosts;

            Console.WriteLine("Your profit will be $" + totalProfit);
        }
      
    }
}
