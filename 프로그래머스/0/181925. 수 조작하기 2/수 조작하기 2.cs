using System;

public class Solution {
    public string solution(int[] numLog) {
        int num = numLog[0];
        string result = "";
        for(int i = 1; i < numLog.Length; i++)
        {
            int value = numLog[i] - num;
            num = numLog[i];
            switch(value)
            {
                case 1:
                    result += "w";
                    break;
                case -1:
                    result += "s";
                    break;
                case 10:
                    result += "d";
                    break;
                case -10:
                    result += "a";
                    break;
                default:
                    break;
            }
            
        }
        return result;
    }
}