using System;
using System.Collections.Generic;

namespace MyTestingField
{
    class Program
    {
        static bool Palindrome(int n, int b)
        {
            List<int> list = new List<int>();
            while(n > 0)
            {
                list.Add(n % b);
                n /= b;
            }
            int count = list.Count;
            for(int i = 0; i < count; i++)
            {
                if(list[i] != list[count - i - 1])
                    return false;
            }
            return true;
        }
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            for(int i = 0; i < t; i++)
            {
                int n = int.Parse(Console.ReadLine());
                bool isPalindrome = false;
                for (int j = 2; j <= 64; j++)
                {
                    if(Palindrome(n, j))
                    {
                        isPalindrome = true;
                        break;
                    }
                }
                if (isPalindrome)
                    Console.WriteLine(1);
                else
                    Console.WriteLine(0);
            }
        }
    }
}