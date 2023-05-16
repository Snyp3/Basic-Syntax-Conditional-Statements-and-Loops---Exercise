namespace P05._Login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userName = Console.ReadLine();
            char[] passwordArray = userName.ToCharArray();Array.Reverse(passwordArray);
            string password = new string(passwordArray);
            
            int count = 0;
            for (int i = 1; i <= 4; i++)
            {
                string inputPassword = Console.ReadLine();
                if (password == inputPassword)
                {
                    Console.WriteLine($"User {userName} logged in.");
                    break;

                }
                else
                {
                    count++;
                    if (count == 4)
                    {
                        Console.WriteLine($"User {userName} blocked!");
                        break;                        
                    }
                    Console.WriteLine("Incorrect password. Try again.");
                }                            
            }
           
        }
    }
}