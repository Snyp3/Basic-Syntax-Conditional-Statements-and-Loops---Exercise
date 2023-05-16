namespace P04._Print_and_sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int sum = 0;
            
            while (start <= end)
            {
                sum += start;
                Console.Write(start + " ");
                start++;
            }
            Console.WriteLine();
            Console.WriteLine($"Sum: {sum}");
        }
    }
}