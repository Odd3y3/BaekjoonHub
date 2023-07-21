using System;

public class Solution {
    public int[,] solution(int n) {
        int[,] answer = new int[n, n];
        int dir = 1;
        int count = 1;
        int x = 0;
        int y = 0;

        while(count <= n * n)
        {
            answer[x, y] = count;
            count++;

            switch(dir)
            {
                case 0:
                    if (x == 0 || answer[x - 1, y] != 0)
                    {
                        dir = (dir + 1) % 4;
                        y++;
                    }
                    else
                    {
                        x--;
                    }
                    break;
                case 1:
                    if(y + 1 == n || answer[x, y + 1] != 0)
                    {
                        dir = (dir + 1) % 4;
                        x++;
                    }
                    else
                    {
                        y++;
                    }
                    break;
                case 2:
                    if(x + 1 == n || answer[x + 1, y] != 0)
                    {
                        dir = (dir + 1) % 4;
                        y--;
                    }
                    else
                    {
                        x++;
                    }
                    break;
                case 3:
                    if (y == 0 || answer[x, y - 1] != 0)
                    {
                        dir = (dir + 1) % 4;
                        x--;
                    }
                    else
                    {
                        y--;
                    }
                    break;
            }
        }
        return answer;
    }
}