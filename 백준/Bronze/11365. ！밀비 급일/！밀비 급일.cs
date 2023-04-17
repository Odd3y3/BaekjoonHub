string input;
while((input = Console.ReadLine()) != "END")
{
    foreach (var item in input.Reverse())
    {
        Console.Write(item);
    }
    Console.WriteLine();
}