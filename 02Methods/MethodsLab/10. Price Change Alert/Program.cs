using System;

class PriceChangeAlert
{
    static void Main()
    {
        int numberOfPrice = int.Parse(Console.ReadLine());
        double priceLimit = double.Parse(Console.ReadLine());
        double lastPrice = double.Parse(Console.ReadLine());

        for (int i = 0; i < numberOfPrice - 1; i++)
        {
            double currentPrice= double.Parse(Console.ReadLine());
            double priceDifference = Proc(lastPrice,currentPrice);
            bool isSignificantDifference = HasDiferrence(priceDifference, priceLimit);

            string message = InfoMessage(currentPrice, lastPrice, priceDifference, isSignificantDifference);
            Console.WriteLine(message);

            lastPrice = currentPrice;
        }
    }

    private static string InfoMessage(double currentPrice, double lastPrice, double difference, bool isSignificantDifference)

    {
        string info = "";
        if (difference == 0)
        {
            info = string.Format("NO CHANGE: {0}", currentPrice);
        }
        else if (!isSignificantDifference)
        {
            info = string.Format("MINOR CHANGE: {0} to {1} ({2:F2}%)", lastPrice, currentPrice, difference*100);
        }
        else if (isSignificantDifference && (difference > 0))
        {
            info = string.Format("PRICE UP: {0} to {1} ({2:F2}%)", lastPrice, currentPrice, difference*100);
        }
        else if (isSignificantDifference && (difference < 0))
            info = string.Format("PRICE DOWN: {0} to {1} ({2:F2}%)", lastPrice, currentPrice, difference*100);
        return info;
    }
    private static bool HasDiferrence(double difference, double priceLimit)
    {
        if (Math.Abs(difference) >= priceLimit)
        {
            return true;
        }
        else
        {
            return false;
        }
        
    }

    private static double Proc(double lastPrice, double price)
    {
        double difference = (price - lastPrice) / lastPrice;
        return difference;
    }
}
