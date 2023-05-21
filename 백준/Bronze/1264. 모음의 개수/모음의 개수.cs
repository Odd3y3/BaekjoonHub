
namespace TestingField
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            char[] mo = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
            while((input = Console.ReadLine()) != "#")
            {
                int result = 0;
                for(int i = 0; i < input.Length; i++)
                {
                    if (mo.Contains(input[i]))
                        result++;
                }
                Console.WriteLine(result);
            }
        }
    }
}

