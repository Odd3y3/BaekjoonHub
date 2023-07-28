int n = int.Parse(Console.ReadLine());
int answer = 0;
for(int i = 0; i < n; i++)
{
    answer += int.Parse(Console.ReadLine());
}
answer = answer - n + 1;
Console.WriteLine(answer);