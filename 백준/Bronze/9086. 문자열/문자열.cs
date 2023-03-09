int t = int.Parse(Console.ReadLine());
for(int i = 0; i < t; i++)
{
    string str = Console.ReadLine();
    Console.Write(str[0]);
    Console.WriteLine(str[str.Length - 1]);
}