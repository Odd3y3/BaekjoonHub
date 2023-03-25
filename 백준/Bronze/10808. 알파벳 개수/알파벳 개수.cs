string input = Console.ReadLine();
int[] count = new int[26];
foreach (var item in input)
{
    count[item - 'a']++;
}
Console.WriteLine(string.Join(" ", count));