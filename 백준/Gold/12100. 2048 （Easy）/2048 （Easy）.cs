
namespace TestingField
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] board = new int[n, n];
            for(int i = 0; i < n; i++)
            {
                int[] temp = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for(int j = 0; j < n; j++)
                {
                    board[i, j] = temp[j];
                }
            }
            int result = 0;
            DFS(5, board, ref result);
            Console.WriteLine(result);
        }
        static void DFS(int count, int[,] board, ref int result)
        {
            if(count == 0)
            {
                foreach (var item in board)
                {
                    result = Math.Max(result, item);
                }
            }
            else
            {
                DFS(count - 1, MoveBoard(0, board), ref result);
                DFS(count - 1, MoveBoard(1, board), ref result);
                DFS(count - 1, MoveBoard(2, board), ref result);
                DFS(count - 1, MoveBoard(3, board), ref result);
            }
        }
        static int[,] MoveBoard(int dir, int[,] board)
        {
            int n = board.GetLength(0);
            int[,] newBoard = new int[n, n];
            List<int> list = new List<int>();
            
            if(dir == 0)    //좌
            {
                for(int i = 0; i < n; i++)
                {
                    int prevNum = 0;
                    list.Clear();
                    for(int j = 0; j < n; j++)
                    {
                        if(prevNum == 0)
                            prevNum = board[i, j];
                        else if(prevNum != board[i, j] && board[i, j] != 0)
                        {
                            list.Add(prevNum);
                            prevNum = board[i, j];
                        }
                        else if(prevNum == board[i, j])
                        {
                            list.Add(prevNum + prevNum);
                            prevNum = 0;
                        }
                    }
                    if (prevNum != 0)
                        list.Add(prevNum);
                    //리스트 구햇으니 그걸로 새 board 한 줄 만들기
                    int index = 0;
                    foreach (var item in list)
                    {
                        newBoard[i, index] = item;
                        index++;
                    }
                }
            }
            else if(dir == 1)
            {
                for (int i = 0; i < n; i++)
                {
                    int prevNum = 0;
                    list.Clear();
                    for (int j = n - 1; j >= 0; j--)
                    {
                        if (prevNum == 0)
                            prevNum = board[i, j];
                        else if (prevNum != board[i, j] && board[i, j] != 0)
                        {
                            list.Add(prevNum);
                            prevNum = board[i, j];
                        }
                        else if(prevNum == board[i, j])
                        {
                            list.Add(prevNum + prevNum);
                            prevNum = 0;
                        }
                    }
                    if (prevNum != 0)
                        list.Add(prevNum);
                    //리스트 구햇으니 그걸로 새 board 한 줄 만들기
                    int index = n - 1;
                    foreach (var item in list)
                    {
                        newBoard[i, index] = item;
                        index--;
                    }
                }
            }
            else if(dir == 2)
            {
                for (int j = 0; j < n; j++)
                {
                    int prevNum = 0;
                    list.Clear();
                    for (int i = 0; i < n; i++)
                    {
                        if (prevNum == 0)
                            prevNum = board[i, j];
                        else if (prevNum != board[i, j] && board[i, j] != 0)
                        {
                            list.Add(prevNum);
                            prevNum = board[i, j];
                        }
                        else if(prevNum == board[i, j])
                        {
                            list.Add(prevNum + prevNum);
                            prevNum = 0;
                        }
                    }
                    if (prevNum != 0)
                        list.Add(prevNum);
                    //리스트 구햇으니 그걸로 새 board 한 줄 만들기
                    int index = 0;
                    foreach (var item in list)
                    {
                        newBoard[index, j] = item;
                        index++;
                    }
                }
            }
            else        //dir == 3
            {
                for (int j = 0; j < n; j++)
                {
                    int prevNum = 0;
                    list.Clear();
                    for (int i = n - 1; i >= 0; i--)
                    {
                        if (prevNum == 0)
                            prevNum = board[i, j];
                        else if (prevNum != board[i, j] && board[i, j] != 0)
                        {
                            list.Add(prevNum);
                            prevNum = board[i, j];
                        }
                        else if(prevNum == board[i, j])
                        {
                            list.Add(prevNum + prevNum);
                            prevNum = 0;
                        }
                    }
                    if (prevNum != 0)
                        list.Add(prevNum);
                    //리스트 구햇으니 그걸로 새 board 한 줄 만들기
                    int index = n - 1;
                    foreach (var item in list)
                    {
                        newBoard[index, j] = item;
                        index--;
                    }
                }
            }
            return newBoard;
        }
    }
}