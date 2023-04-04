string[] input = Console.ReadLine().Split();
int num = int.Parse(input[0]) * int.Parse(input[1]);
int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
int[] result = new int[5];
for(int i = 0; i < 5; i++){
    result[i] = arr[i] - num;
}
Console.WriteLine(string.Join(' ', result));