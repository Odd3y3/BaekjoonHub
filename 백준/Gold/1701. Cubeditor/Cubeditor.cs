
namespace TestingField
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int i = 1;
            int result = 0;
            while(i < input.Length)
            {
                int temp = 0;
                for(int k = 0; k < input.Length - i; k++)
                {
                    if (input[k + i] == input[k])
                    {
                        temp++;
                        if(temp > result)
                            result = temp;
                    }
                    else
                    {
                        temp = 0;
                    }
                }
                i++;
            }

            Console.WriteLine(result);
        }
    }
}