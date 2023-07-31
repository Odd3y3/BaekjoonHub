int n = int.Parse(Console.ReadLine());
int[] arr = new int[n];
for(int i = 0; i < n; i++)
{
    arr[i] = int.Parse(Console.ReadLine());
}
Array.Sort(arr);
int answer = 0;
for(int i = 0; i < n; i++)
{
    answer = Math.Max(answer, arr[i] * (n - i));
}
Console.WriteLine(answer);