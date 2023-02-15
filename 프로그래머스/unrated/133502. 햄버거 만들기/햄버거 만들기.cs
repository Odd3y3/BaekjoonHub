using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int[] ingredient) {
        Stack<int> stack = new Stack<int>();
        int present = 0;
        int result = 0;
        foreach (int item in ingredient)
        {
            if (present == 0 && stack.Count > 0)
                present = stack.Pop();

            if(present == 0)
            {
                if (item == 1)
                    present++;
                else
                {
                    present = 0;
                    stack.Clear();
                }    
            }
            else if(present == 1)
            {
                if (item == 1)
                {
                    stack.Push(present);
                    present = 1;
                }
                else if (item == 2)
                    present++;
                else
                {
                    present = 0;
                    stack.Clear();
                }
            }
            else if (present == 2)
            {
                if (item == 1)
                {
                    stack.Push(present);
                    present = 1;
                }
                else if (item == 3)
                    present++;
                else
                {
                    present = 0;
                    stack.Clear();
                }
            }
            else if (present == 3)
            {
                if (item == 1)
                {
                    present = 0;
                    result++;
                }
                else
                {
                    present = 0;
                    stack.Clear();
                }
            }
        }
        return result;
    }
}