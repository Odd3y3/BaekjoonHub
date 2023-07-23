using System;

public class Solution {
    public string solution(string myString) {
        char[] chars = new char[myString.Length];
        for(int i = 0; i < chars.Length; i++)
        {
            if (myString[i] < 'l')
                chars[i] = 'l';
            else
                chars[i] = myString[i];
        }

        return string.Join("", chars);
    }
}