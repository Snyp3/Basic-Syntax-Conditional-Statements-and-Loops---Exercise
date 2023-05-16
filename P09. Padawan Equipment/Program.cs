namespace P09._Padawan_Equipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double amountOfMoney = double.Parse(Console.ReadLine());
            double countOfStudents = double.Parse(Console.ReadLine()) ;
            double priceOfLightsabers = double.Parse(Console.ReadLine());
            double priceOfRobes = double.Parse(Console.ReadLine());
            double priceOfBelts = double.Parse(Console.ReadLine());
            double totalMoney = 0;
            double countBelts = 0;

            
            double countLightsabers = (countOfStudents + Math.Ceiling(countOfStudents * 0.1));
            double freeBelt = Math.Floor(countOfStudents / 6);
             
            double countRobes = countOfStudents;

            if (freeBelt >= 1)
            {
                countBelts = countOfStudents - freeBelt;
            }
            else
            {
                countBelts = countOfStudents;
            }

            totalMoney = priceOfLightsabers * countLightsabers + priceOfRobes * countRobes +
                priceOfBelts * countBelts;

           if (amountOfMoney >= totalMoney)
            {
                Console.WriteLine("The money is enough - it would cost " +
                    $"{totalMoney:f2}lv.");
            }
           else
            {
                Console.WriteLine($" John will need {totalMoney - amountOfMoney:f2}lv more.");
            }
        }
    }
}