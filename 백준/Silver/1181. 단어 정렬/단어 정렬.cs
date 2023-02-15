using System;
using System.Linq;

namespace MyTestingField
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] strings = new string[n];

            for (int i = 0; i < n; i++)
            {
                strings[i] = Console.ReadLine();
            }
            Array.Sort(strings);
            strings = strings.Distinct().OrderBy(x => x.Length).ToArray();

            foreach (var item in strings)
            {
                Console.WriteLine(item);
                
            }
        }
    }
}