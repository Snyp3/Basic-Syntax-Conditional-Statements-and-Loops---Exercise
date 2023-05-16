namespace P07._Vending_Machine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            string products = "";
            double totalSumGathered = 0;
            double nutsPrice = 2.0;
            double waterPrice = 0.7;
            double crispsPrice = 1.5;
            double sodaPrice = 0.8;
            double cokePrice = 1.0;
            double inputCoins = 0;

            while ((input = Console.ReadLine()) != "Start")
            {
                inputCoins = double.Parse(input);
                if (inputCoins == 0.1 || inputCoins == 0.2 || inputCoins == 0.5 ||
                    inputCoins == 1 || inputCoins == 2)
                {
                totalSumGathered += inputCoins;
                }
                else
                {
                Console.WriteLine($"Cannot accept {inputCoins}");
                }
            }
            while ((products = Console.ReadLine()) != "End")
            {
                if (totalSumGathered < 0)
                {
                    break;
                }
                if (products == "Nuts")
                {
                    if (totalSumGathered < nutsPrice)
                    {
                        Console.WriteLine("Sorry, not enough money");
                        
                    }
                    totalSumGathered -= nutsPrice;
                    Console.WriteLine("Purchased nuts");
                }
                else if (products == "Water")
                {
                    if (totalSumGathered < waterPrice)
                    {
                        Console.WriteLine("Sorry, not enough money");
                        
                    }
                    totalSumGathered -= waterPrice;
                    Console.WriteLine("Purchased water");
                }
                else if (products == "Crisps")
                {
                    if (totalSumGathered < crispsPrice)
                    {
                        Console.WriteLine("Sorry, not enough money");
                        
                    }
                    totalSumGathered -= crispsPrice;
                    Console.WriteLine("Purchased crisps");
                }
                else if (products == "Soda")
                {
                    if (totalSumGathered < sodaPrice)
                    {
                        Console.WriteLine("Sorry, not enough money");
                        
                    }
                    totalSumGathered -= sodaPrice;
                    Console.WriteLine("Purchased soda");
                }   
                else if (products == "Coke")
                {
                    if (totalSumGathered < cokePrice)
                    {
                        Console.WriteLine("Sorry, not enough money");
                        
                    }
                    totalSumGathered -= cokePrice;
                    Console.WriteLine("Purchased coke");
                }
                else
                {
                    Console.WriteLine("Invalid product");
                }
                
            }

            Console.WriteLine($"Change: {totalSumGathered:f2}");
            
        }
    }
}