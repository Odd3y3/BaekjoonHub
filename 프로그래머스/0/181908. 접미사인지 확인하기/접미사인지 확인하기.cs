using System;

public class Solution {
    public int solution(string my_string, string is_suffix) {
        if(is_suffix.Length > my_string.Length)
            return 0;
        string sub = my_string.Substring(my_string.Length - is_suffix.Length, is_suffix.Length);
        return sub == is_suffix ? 1 : 0;
    }
}