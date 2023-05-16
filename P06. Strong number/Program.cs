namespace P06._Strong_number
{
    internal class Program
    {
        static void Main(string[] args)
        
        {
            int number = int.Parse(Console.ReadLine());
            int numberSave = number;

            int factorielSum = 0;                      
 
            
            while (number > 0)
            {
                
                int newNumb = number % 10;
                int factoriel = 1;
                for (int i = 1; i <= newNumb; i++)
                {
                    factoriel *= i;
                }
                               
                factorielSum += factoriel;
                number /= 10;
                
               
            }
            if (factorielSum == numberSave)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}