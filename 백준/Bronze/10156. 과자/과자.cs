int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
int result = input[0] * input[1] - input[2];
if (result < 0) result = 0;
Console.WriteLine(result);