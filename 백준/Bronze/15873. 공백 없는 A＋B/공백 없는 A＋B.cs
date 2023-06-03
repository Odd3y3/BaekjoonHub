string input = Console.ReadLine();
int result = 0;
foreach (var item in input)
{
    if (item == '0')
        result += 9;
    else
        result += int.Parse(item.ToString());
}
Console.WriteLine(result);