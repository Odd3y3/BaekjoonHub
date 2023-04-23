string[] input = Console.ReadLine().Split();
int p1x = int.Parse(input[0]);
int p1y = int.Parse(input[1]);
input = Console.ReadLine().Split();
int p2x = int.Parse(input[0]);
int p2y = int.Parse(input[1]);
input = Console.ReadLine().Split();
int p3x = int.Parse(input[0]);
int p3y = int.Parse(input[1]);

int x1 = p2x - p1x;
int y1 = p2y - p1y;
int x2 = p3x - p2x;
int y2 = p3y - p2y;
int result = x1 * y2 - x2 * y1;
if (result == 0)
    Console.WriteLine(0);
else if (result > 0)
    Console.WriteLine(1);
else
    Console.WriteLine(-1);