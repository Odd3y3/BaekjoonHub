
using System.Text;

namespace TestingField
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            int n = int.Parse(Console.ReadLine());
            for(int i = 0; i < n; i++)
            {
                sb.AppendLine($" @@@   @@@ \n@   @ @   @\n@    @    @\n@         @\n @       @ \n  @     @  \n   @   @   \n    @ @    \n     @     ");
            }
            Console.WriteLine(sb);
        }
    }
    
}