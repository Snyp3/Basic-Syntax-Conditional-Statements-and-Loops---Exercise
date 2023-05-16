namespace P10._Rage_Expenses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double lostGames = int.Parse(Console.ReadLine());
            double priceHeadset = double.Parse(Console.ReadLine());
            double priceMouse = double.Parse(Console.ReadLine());
            double priceKeyboard = double.Parse(Console.ReadLine());
            double priceDisplay = double.Parse(Console.ReadLine());

            int trashedKeyboard = 0;
            int trashedDisplay = 0;
            double trashedHeadset = 0;
            double trashedMouse = 0;
           
            for (int i = 1; i <= lostGames; i++)
            {
                if (i % 2 == 0)
                {
                    trashedHeadset += 1;

                }
                if (i % 3 == 0)
                {
                    trashedMouse += 1;
                }                
                if (i% 2 == 0 && i % 3 == 0 )
                {
                    trashedKeyboard += 1;
                    if (trashedKeyboard >= 2 && trashedKeyboard % 2 == 0)
                    {
                        trashedDisplay += 1;
                    }
                }
              
            }
            double expenses = priceDisplay * trashedDisplay + priceKeyboard * trashedKeyboard +
                priceMouse * trashedMouse + priceHeadset * trashedHeadset;
            Console.WriteLine($"Rage expenses: {expenses:f2} lv.");
        }
    }
}