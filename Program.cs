namespace CountSpace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a sentence:");
            string input = Console.ReadLine();

            int spaceCount = 0;

            foreach (char c in input)
            {
                if (c == ' ')
                {
                    spaceCount++;
                }
            }

            Console.WriteLine("Total spaces: " + spaceCount);
        }
    }
}
