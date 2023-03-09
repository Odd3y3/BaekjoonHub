
using System.Text;

namespace TestingField
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char c in Console.ReadLine())
            {
                if (c >= 'a' && c <= 'z')
                    sb.Append(char.ToUpper(c));
                else
                    sb.Append(char.ToLower(c));
            }
            Console.WriteLine(sb);
        }
    }
}