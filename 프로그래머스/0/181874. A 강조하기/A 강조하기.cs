using System;

public class Solution {
    public string solution(string myString) {
        myString = myString.ToLower();
        char[] cArr = new char[myString.Length];
        for(int i = 0; i < myString.Length; i++)
        {
            if(myString[i] == 'a')
                cArr[i] = 'A';
            else
                cArr[i] = myString[i];
        }
        return string.Join("", cArr);
    }
}