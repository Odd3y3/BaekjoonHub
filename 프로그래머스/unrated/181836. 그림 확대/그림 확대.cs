using System;
using System.Collections.Generic;

public class Solution {
    public string[] solution(string[] picture, int k) {
        List<string> answer = new List<string>();
        foreach (string str in picture)
        {
            int length = str.Length * k;
            List<char> newLine = new List<char>();
            foreach (char c in str)
            {
                for(int i = 0; i < k; i++)
                    newLine.Add(c);
            }

            for (int i = 0; i < k; i++)
                answer.Add(string.Join("", newLine));
        }
        return answer.ToArray();
    }
}