using System.Runtime.InteropServices;

internal class Program
{
    private static void Main(string[] args)
    {
        int countOfPeople = int.Parse(Console.ReadLine());
        string typeOfGroup = Console.ReadLine();
        string day = Console.ReadLine();
        double pricePerPerson = 0;
        /*
         *Type of the group (Students, Business or Regular).
        • The day of the week which the group will stay on (Friday, Saturday or Sunday)
        */

        switch (typeOfGroup)
        {
            case "Students":
                switch (day)
                {

                    case "Friday":
                        pricePerPerson = 8.45;
                        break;
                    case "Saturday":
                        pricePerPerson = 9.80;
                        break;
                    case "Sunday":
                        pricePerPerson = 10.46;
                        break;
                }
                break;

            case "Business":
                switch (day)
                {
                    case "Friday":
                        pricePerPerson = 10.90;
                        break;
                    case "Saturday":
                        pricePerPerson = 15.60;
                        break;
                    case "Sunday":
                        pricePerPerson = 16;
                        break;

                }
                break;

            case "Regular":
                switch (day)
                {
                    case "Friday":
                        pricePerPerson = 15;
                        break;
                    case "Saturday":
                        pricePerPerson = 20;
                        break;
                    case "Sunday":
                        pricePerPerson = 22.50;
                        break;
                }
                break;
        }  

        double totalPrice = pricePerPerson * countOfPeople;

        if (countOfPeople >= 30 && typeOfGroup == "Students")
        {
            totalPrice -= totalPrice * 0.15;
        }
        else if (countOfPeople >= 100 && typeOfGroup == "Business")
        {
            totalPrice -= pricePerPerson * 10;
        }
        else if (countOfPeople >= 10 && countOfPeople <= 20 &&  typeOfGroup == "Regular")
        {
            totalPrice -= totalPrice * 0.05;
        }

        Console.WriteLine($"Total price: {totalPrice:f2}");
    }
}