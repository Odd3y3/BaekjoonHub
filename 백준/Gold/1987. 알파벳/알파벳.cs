
namespace TestingField
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int r = int.Parse(input[0]);
            int c = int.Parse(input[1]);
            char[,] board = new char[r, c];
            for(int i = 0; i < r; i++)
            {
                string temp = Console.ReadLine();
                for(int j = 0; j < c; j++)
                {
                    board[i, j] = temp[j];
                }
            }

            int result = 0;
            DFS(0, 0, new bool[26], board, ref result, 1);
            Console.WriteLine(result);
        }
        static void DFS(int x, int y, bool[] checkArr, char[,] board, ref int result, int count)
        {
            checkArr[board[x, y] - 'A'] = true;

            result = Math.Max(result, count);
            if (result == 26)
                return;

            if (x > 0 && !checkArr[board[x - 1, y] - 'A'])
                DFS(x - 1, y, checkArr, board, ref result, count + 1);
            if (y > 0 && !checkArr[board[x, y - 1] - 'A'])
                DFS(x, y - 1, checkArr, board, ref result, count + 1);
            if (x < board.GetLength(0) - 1 && !checkArr[board[x + 1, y] - 'A'])
                DFS(x + 1, y, checkArr, board, ref result, count + 1);
            if (y < board.GetLength(1) - 1 && !checkArr[board[x, y + 1] - 'A'])
                DFS(x, y + 1, checkArr, board, ref result, count + 1);

            checkArr[board[x, y] - 'A'] = false;
        }
        
    }
}