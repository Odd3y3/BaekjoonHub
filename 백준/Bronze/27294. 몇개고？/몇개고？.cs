string[] input = Console.ReadLine().Split(' ');
int n = int.Parse(input[0]);
Console.WriteLine(n >= 12 && n <= 16 && input[1] == "0" ? 320 : 280);