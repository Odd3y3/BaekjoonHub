
namespace TestingField
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            string[] inputs;
            while((input = Console.ReadLine()) != "0 0")
            {
                inputs = input.Split(' ');
                if (int.Parse(inputs[0]) > int.Parse(inputs[1]))
                    Console.WriteLine("Yes");
                else
                    Console.WriteLine("No");
            }
        }
    }
}