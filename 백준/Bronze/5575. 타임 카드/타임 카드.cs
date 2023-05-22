for(int i = 0; i < 3; i++)
{
    int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
    int Start = input[0] * 3600 + input[1] * 60 + input[2];
    int End = input[3] * 3600 + input[4] * 60 + input[5];

    int time = End - Start;
    int h = time / 3600;
    time = time % 3600;
    int m = time / 60;
    int s = time % 60;
    Console.WriteLine(h + " " + m + " " + s);
}