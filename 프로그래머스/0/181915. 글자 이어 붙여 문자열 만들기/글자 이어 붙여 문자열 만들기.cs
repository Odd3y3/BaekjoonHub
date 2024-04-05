using System;

public class Solution {
    public string solution(string my_string, int[] index_list) {
        char[] arr = new char[index_list.Length];
        for(int i = 0; i < index_list.Length; i++){
            arr[i] = my_string[index_list[i]];
        }
        
        return string.Join("", arr);
    }
}