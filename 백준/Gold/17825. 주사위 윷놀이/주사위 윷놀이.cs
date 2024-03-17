
namespace TestingField
{
    internal class Program
    {
        class Node
        {
            public int point = 0;
            public int nextNode;
            public int nextBlueNode;
            public Node(int point, int nextNode, int nextBlueNode)
            {
                this.point = point;
                this.nextNode = nextNode;
                this.nextBlueNode = nextBlueNode;
            }
        }
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
            Node[] map = new Node[33];
            //맵설정
            for(int i = 0; i <= 20; i++)
            {
                map[i] = new Node(i * 2, i + 1, 0);
            }
            map[20].nextNode = 32;

            map[21] = new Node(13, 22, 0);
            map[22] = new Node(16, 23, 0);
            map[23] = new Node(19, 24, 0);
            
            map[24] = new Node(25, 30, 0);

            map[25] = new Node(22, 26, 0);
            map[26] = new Node(24, 24, 0);

            map[27] = new Node(28, 28, 0);
            map[28] = new Node(27, 29, 0);
            map[29] = new Node(26, 24, 0);

            map[30] = new Node(30, 31, 0);
            map[31] = new Node(35, 20, 0);

            map[32] = new Node(0, 32, 0);

            //파란색 화살표
            map[5].nextBlueNode = 21;
            map[10].nextBlueNode = 25;
            map[15].nextBlueNode = 27;

            
            //progress

            int result = 0;
            Solve(input, map, ref result);
            Console.WriteLine(result);
        }

        static void Solve(int[] input, Node[] map, ref int result)
        {
            Recursive(0, input, 0, 0, 0, 0, 0, map, ref result);
        }

        static void Recursive(int idx, int[] input, int value, 
            int player1, int player2, int player3, int player4, Node[] map, ref int result)
        {
            if(idx == 10)
            {
                if (value > result)
                    result = value;
                return ;
            }

            int dice = input[idx];

            int pos = Move(dice, player1, true, map);
            if((pos == 32) || (pos != player2 && pos != player3 && pos != player4))
                Recursive(idx + 1, input, value + map[pos].point, pos, player2, player3, player4, map, ref result);

            pos = Move(dice, player2, true, map);
            if ((pos == 32) || (pos != player1 && pos != player3 && pos != player4))
                Recursive(idx + 1, input, value + map[pos].point, player1, pos, player3, player4, map, ref result);

            pos = Move(dice, player3, true, map);
            if ((pos == 32) || (pos != player1 && pos != player2 && pos != player4))
                Recursive(idx + 1, input, value + map[pos].point, player1, player2, pos, player4, map, ref result);

            pos = Move(dice, player4, true, map);
            if ((pos == 32) || (pos != player1 && pos != player2 && pos != player3))
                Recursive(idx + 1, input, value + map[pos].point, player1, player2, player3, pos, map, ref result);
        }

        static int Move(int dice, int playerPosIdx, bool isStart, Node[] map)
        {
            if(dice == 0)
            {
                return playerPosIdx;
            }

            if(isStart && map[playerPosIdx].nextBlueNode != 0)
            {
                return Move(dice - 1, map[playerPosIdx].nextBlueNode, false, map);
            }
            else
                return Move(dice - 1, map[playerPosIdx].nextNode, false, map);
        }
    }
}                           