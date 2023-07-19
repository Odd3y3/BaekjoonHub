
namespace TestingField
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int n = int.Parse(input[0]);
            int m = int.Parse(input[1]);
            input = Console.ReadLine().Split();
            int r = int.Parse(input[0]);
            int c = int.Parse(input[1]);
            int d = int.Parse(input[2]);

            int[,] map = new int[n, m];
            for(int i = 0; i < n; i++)
            {
                input = Console.ReadLine().Split();
                for(int j = 0; j < m; j++)
                    map[i, j] = int.Parse(input[j]);
            }

            //process
            int answer = 0;
            while (true)
            {
                if (map[r, c] == 0)
                {
                    map[r, c] = 2;
                    answer++;
                }

                if(IsBlankAround(r, c, map))
                {
                    d = (d + 3) % 4;

                    int tempR = r;
                    int tempC = c;
                    switch (d)
                    {
                        case 0:
                            tempR--;
                            break;
                        case 1:
                            tempC++;
                            break;
                        case 2:
                            tempR++;
                            break;
                        case 3:
                            tempC--;
                            break;
                    }
                    if (tempR >= 0 && tempR < n && tempC >= 0 && tempC < m)
                    {
                        if (map[tempR, tempC] == 0)
                        {
                            r = tempR;
                            c = tempC;
                        }
                    }
                }
                else
                {
                    int tempR = r;
                    int tempC = c;
                    switch (d)
                    {
                        case 0:
                            tempR++;
                            break;
                        case 1:
                            tempC--;
                            break;
                        case 2:
                            tempR--;
                            break;
                        case 3:
                            tempC++;
                            break;
                    }
                    if (tempR >= 0 && tempR < n && tempC >= 0 && tempC < m
                        && (map[tempR, tempC] == 0 || map[tempR, tempC] == 2))
                    {
                        r = tempR;
                        c = tempC;
                    }
                    else
                    {
                        break;
                    }
                }
            }

            Console.WriteLine(answer);
        }

        static bool IsBlankAround(int r, int c, int[,] map)
        {
            bool answer = false;

            if (!answer && r > 0 && map[r - 1, c] == 0)
                answer = true;
            if (!answer && c > 0 && map[r, c - 1] == 0)
                answer = true;
            if (!answer && r < map.GetLength(0) - 1 && map[r + 1, c] == 0)
                answer = true;
            if (!answer && c < map.GetLength(1) - 1 && map[r, c + 1] == 0)
                answer = true;
            return answer;
        }
    }
}