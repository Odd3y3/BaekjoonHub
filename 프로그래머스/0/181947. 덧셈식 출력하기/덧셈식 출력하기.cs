using System;
using System.Linq;

public class Example
{
    public static void Main()
    {
        int[] input = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
        Console.WriteLine($"{input[0]} + {input[1]} = {input[0] + input[1]}");
    }
}