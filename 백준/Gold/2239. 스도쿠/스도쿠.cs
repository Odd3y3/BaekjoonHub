
namespace TestingField
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] board = new int[9, 9];
            for(int i = 0; i < 9; i++)
            {
                char[] input = Console.ReadLine().ToCharArray();
                for(int j = 0; j < 9; j++)
                {
                    board[i, j] = input[j] - '0';
                }
            }

            Solve(0, board);

            for(int i = 0; i < 9; i++)
            {
                for(int j = 0; j < 9; j++)
                {
                    Console.Write(board[i, j]);
                }
                Console.WriteLine();
            }
        }

        static bool Solve(int n, int[,] board)
        {
            if (n == 81)
                return true;

            int i = n / 9;
            int j = n % 9;
            if (board[i, j] != 0)
            {
                if(Solve(n + 1, board))
                {
                    return true;
                }
            }
            else
            {
                for(int index = 1; index <= 9; index++)
                {
                    if(CanPlaceHere(i, j, index, board))
                    {
                        board[i, j] = index;
                        if(Solve(n + 1, board))
                        {
                            return true;
                        }
                        board[i, j] = 0;
                    }

                }
            }

            return false;
        }

        static bool CanPlaceHere(int i, int j, int num, int[,] board)
        {
            for(int index = 0; index < 9; index++)
            {
                if (board[index, j] == num)
                    return false;
                if (board[i, index] == num)
                    return false;
            }
            i /= 3;
            j /= 3;
            for(int x = 0; x < 3; x++)
            {
                for(int y = 0; y < 3; y++)
                {
                    if (board[i * 3 + x, j * 3 + y] == num)
                        return false;
                }
            }

            return true;
        }
    }
}