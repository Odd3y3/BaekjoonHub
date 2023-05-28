int n = int.Parse(Console.ReadLine());
bool[] arr = new bool[Math.Max(n + 1, 5)];
arr[1] = false;
arr[2] = true;
arr[3] = false;
arr[4] = true;
for(int i = 5; i <= n; i++)
{
    if (!arr[i - 1] || !arr[i - 3] || !arr[i - 4])
        arr[i] = true;
    else
        arr[i] = false;
}
if (arr[n])
    Console.WriteLine("SK");
else
    Console.WriteLine("CY");