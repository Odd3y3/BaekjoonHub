string input;
while((input = Console.ReadLine()) != "# 0 0")
{
    string[] arr = input.Split().ToArray();
    if (int.Parse(arr[1]) > 17 || int.Parse(arr[2]) >= 80)
        Console.WriteLine(arr[0] + " Senior");
    else
        Console.WriteLine(arr[0] + " Junior");
}