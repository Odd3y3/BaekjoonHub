using System;

public class Solution {
    public int solution(int[] num_list) {
        string sEven = "";
        string sOdd = "";
        int even = 0;
        int odd = 0;
        foreach(int num in num_list){
            if(num % 2 == 0)
                sEven += num.ToString();
            else
                sOdd += num.ToString();
        }
        if(sEven != string.Empty)
            even = int.Parse(sEven);
        if(sOdd != string.Empty)
            odd = int.Parse(sOdd);
        return even + odd;
    }
}