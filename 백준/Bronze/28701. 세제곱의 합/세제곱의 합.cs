int n = int.Parse(Console.ReadLine());
int result1 = 0;
int result2 = 0;
int result3 = 0;
for (int i = 1; i <= n; i++)
    result1 += i;

result2 = result1 * result1;

for (int i = 1; i <= n; i++)
    result3 += i * i * i;
Console.WriteLine(result1);
Console.WriteLine(result2);
Console.WriteLine(result3);