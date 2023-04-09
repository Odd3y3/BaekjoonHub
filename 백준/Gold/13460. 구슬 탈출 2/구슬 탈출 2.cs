
namespace TestingField
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int n = int.Parse(input[0]);
            int m = int.Parse(input[1]);
            char[,] map = new char[n, m];
            Point red = new Point();
            Point blue = new Point();
            for(int i = 0; i < n; i++)
            {
                string temp = Console.ReadLine();
                for(int j = 0; j < m; j++)
                {
                    if (temp[j] == 'R')
                    {
                        red = new Point(i, j);
                        map[i, j] = '.';
                    }
                    else if (temp[j] == 'B')
                    {
                        blue = new Point(i, j);
                        map[i, j] = '.';
                    }
                    else
                        map[i, j] = temp[j];
                }
            }

            //DFS로 ㄱㄱ
            int result = -1;
            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(new Node(red, blue, 0, false, false));
            while(queue.Count > 0)
            {
                Node node = queue.Dequeue();
                if (node.depth > 10)
                    break;
                else if(node.isRedOut && !node.isBlueOut)
                {
                    result = node.depth;
                    break;
                }
                else if (!node.isBlueOut)
                {
                    queue.Enqueue(MoveLeft(node, map));
                    queue.Enqueue(MoveRight(node, map));
                    queue.Enqueue(MoveUp(node, map));
                    queue.Enqueue(MoveDown(node, map));

                }

            }
            Console.WriteLine(result);
        }
        static Node MoveLeft(Node node, char[,] map)
        {
            int redX = node.red.x;
            int redY = node.red.y;
            int blueX = node.blue.x;
            int blueY = node.blue.y;
            bool isRedFirst = node.red.x < node.blue.x;     //red가 왼쪽에 있으면 red먼저 이동
            bool isRedOut = false;
            bool isBlueOut = false;

            //빨간공 움직이기
            while (isRedFirst)
            {
                if (map[redX - 1, redY] == 'O')
                {
                    redX--;
                    isRedOut = true;
                    break;
                }
                else if (map[redX - 1, redY] == '#' || (redX - 1 == blueX && redY == blueY))
                    break;
                else
                    redX--;
            }
            //파란공 움직이기
            while (true)
            {
                if (map[blueX - 1, blueY] == 'O')
                {
                    blueX--;
                    isBlueOut = true;
                    break;
                }
                else if (map[blueX - 1, blueY] == '#' || (blueX - 1 == redX && blueY == redY))
                    break;
                else
                    blueX--;
            }
            //빨간공 움직이기
            while (!isRedFirst)
            {
                if (map[redX - 1, redY] == 'O')
                {
                    redX--;
                    isRedOut = true;
                    break;
                }
                else if (map[redX - 1, redY] == '#' || (redX - 1 == blueX && redY == blueY))
                    break;
                else
                    redX--;
            }

            Point Red = new Point(redX, redY);
            Point Blue = new Point(blueX, blueY);
            return new Node(Red, Blue, node.depth + 1, isRedOut, isBlueOut);
        }
        static Node MoveRight(Node node, char[,] map)
        {
            int redX = node.red.x;
            int redY = node.red.y;
            int blueX = node.blue.x;
            int blueY = node.blue.y;
            bool isRedFirst = node.red.x > node.blue.x;     //red가 오른쪽에 있으면 red먼저 이동
            bool isRedOut = false;
            bool isBlueOut = false;

            //빨간공 움직이기
            while (isRedFirst)
            {
                if (map[redX + 1, redY] == 'O')
                {
                    redX++;
                    isRedOut = true;
                    break;
                }
                else if (map[redX + 1, redY] == '#' || (redX + 1 == blueX && redY == blueY))
                    break;
                else
                    redX++;
            }
            //파란공 움직이기
            while (true)
            {
                if (map[blueX + 1, blueY] == 'O')
                {
                    blueX++;
                    isBlueOut = true;
                    break;
                }
                else if (map[blueX + 1, blueY] == '#' || (blueX + 1 == redX && blueY == redY))
                    break;
                else
                    blueX++;
            }
            //빨간공 움직이기
            while (!isRedFirst)
            {
                if (map[redX + 1, redY] == 'O')
                {
                    redX++;
                    isRedOut = true;
                    break;
                }
                else if (map[redX + 1, redY] == '#' || (redX + 1 == blueX && redY == blueY))
                    break;
                else
                    redX++;
            }

            Point Red = new Point(redX, redY);
            Point Blue = new Point(blueX, blueY);
            return new Node(Red, Blue, node.depth + 1, isRedOut, isBlueOut);
        }
        static Node MoveUp(Node node, char[,] map)
        {
            int redX = node.red.x;
            int redY = node.red.y;
            int blueX = node.blue.x;
            int blueY = node.blue.y;
            bool isRedFirst = node.red.y < node.blue.y;     //red가 오른쪽에 있으면 red먼저 이동
            bool isRedOut = false;
            bool isBlueOut = false;

            //빨간공 움직이기
            while (isRedFirst)
            {
                if (map[redX, redY - 1] == 'O')
                {
                    redY--;
                    isRedOut = true;
                    break;
                }
                else if (map[redX, redY - 1] == '#' || (redX == blueX && redY - 1 == blueY))
                    break;
                else
                    redY--;
            }
            //파란공 움직이기
            while (true)
            {
                if (map[blueX, blueY - 1] == 'O')
                {
                    blueY--;
                    isBlueOut = true;
                    break;
                }
                else if (map[blueX, blueY - 1] == '#' || (blueX == redX && blueY - 1 == redY))
                    break;
                else
                    blueY--;
            }
            //빨간공 움직이기
            while (!isRedFirst)
            {
                if (map[redX, redY - 1] == 'O')
                {
                    redY--;
                    isRedOut = true;
                    break;
                }
                else if (map[redX, redY - 1] == '#' || (redX == blueX && redY - 1 == blueY))
                    break;
                else
                    redY--;
            }

            Point Red = new Point(redX, redY);
            Point Blue = new Point(blueX, blueY);
            return new Node(Red, Blue, node.depth + 1, isRedOut, isBlueOut);
        }
        static Node MoveDown(Node node, char[,] map)
        {
            int redX = node.red.x;
            int redY = node.red.y;
            int blueX = node.blue.x;
            int blueY = node.blue.y;
            bool isRedFirst = node.red.y > node.blue.y;     //red가 오른쪽에 있으면 red먼저 이동
            bool isRedOut = false;
            bool isBlueOut = false;

            //빨간공 움직이기
            while (isRedFirst)
            {
                if (map[redX, redY + 1] == 'O')
                {
                    redY++;
                    isRedOut = true;
                    break;
                }
                else if (map[redX, redY + 1] == '#' || (redX == blueX && redY + 1 == blueY))
                    break;
                else
                    redY++;
            }
            //파란공 움직이기
            while (true)
            {
                if (map[blueX, blueY + 1] == 'O')
                {
                    blueY++;
                    isBlueOut = true;
                    break;
                }
                else if (map[blueX, blueY + 1] == '#' || (blueX == redX && blueY + 1 == redY))
                    break;
                else
                    blueY++;
            }
            //빨간공 움직이기
            while (!isRedFirst)
            {
                if (map[redX, redY + 1] == 'O')
                {
                    redY++;
                    isRedOut = true;
                    break;
                }
                else if (map[redX, redY + 1] == '#' || (redX == blueX && redY + 1 == blueY))
                    break;
                else
                    redY++;
            }

            Point Red = new Point(redX, redY);
            Point Blue = new Point(blueX, blueY);
            return new Node(Red, Blue, node.depth + 1, isRedOut, isBlueOut);
        }
    }
    class Node
    {
        public Point red;
        public Point blue;
        public int depth;
        public bool isRedOut;
        public bool isBlueOut;
        public Node(Point red, Point blue, int depth, bool isRedOut, bool isBlueOut)
        {
            this.red = red;
            this.blue = blue;
            this.depth = depth;
            this.isRedOut = isRedOut;
            this.isBlueOut = isBlueOut;
        }
    }
    struct Point
    {
        public int x;
        public int y;
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
}
