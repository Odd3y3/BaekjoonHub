using System.Text;
StringBuilder sb = new StringBuilder();
int n = int.Parse(Console.ReadLine());
for (int i = 0; i < n / 5; i++)
    sb.Append("V");
for (int i = 0; i < n % 5; i++)
    sb.Append("I");
Console.WriteLine(sb);