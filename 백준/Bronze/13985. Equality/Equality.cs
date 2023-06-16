string[] input = Console.ReadLine().Split();
int a = int.Parse(input[0]);
int b = int.Parse(input[2]);
int c = int.Parse(input[4]);
if (a + b == c)
    Console.WriteLine("YES");
else Console.WriteLine("NO");