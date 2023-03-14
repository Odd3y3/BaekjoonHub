string input;
int[] arr;
while((input = Console.ReadLine()) != null)
{
    arr = input.Split(' ').Select(int.Parse).ToArray();
    Console.WriteLine(arr[1] / (arr[0] + 1));
}