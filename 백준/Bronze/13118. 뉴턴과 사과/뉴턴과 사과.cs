int[] people = Console.ReadLine().Split().Select(int.Parse).ToArray();
int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
int result = 0;
for(int i = 0; i < 4; i++)
{
    if (people[i] == input[0])
    {
        result = i + 1;
        break;
    }
}
Console.WriteLine(result);