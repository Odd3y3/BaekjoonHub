
namespace TestingField
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] arr =
            {
                "Never gonna give you up",
                "Never gonna let you down",
                "Never gonna run around and desert you",
                "Never gonna make you cry",
                "Never gonna say goodbye",
                "Never gonna tell a lie and hurt you",
                "Never gonna stop"
            };

            bool result = true;
            for(int i = 0; i < n; i++)
            {
                if(!arr.Contains(Console.ReadLine()))
                {
                    result = false;
                    break;
                }
            }

            if (result)
                Console.WriteLine("No");
            else
                Console.WriteLine("Yes");
        }
    }
}