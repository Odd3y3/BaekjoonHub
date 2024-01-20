using System;

public class Example
{
    public static void Main()
    {
        String[] input;

        Console.Clear();
        input = Console.ReadLine().Split(' ');

        foreach(string str in input){
            Console.Write(str);
        }

    }
}