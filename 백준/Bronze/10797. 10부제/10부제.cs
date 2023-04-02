int num = int.Parse(Console.ReadLine());
int result = 0;
foreach (var item in Console.ReadLine().Split().Select(int.Parse))
    if (num == item) result++;
Console.WriteLine(result);