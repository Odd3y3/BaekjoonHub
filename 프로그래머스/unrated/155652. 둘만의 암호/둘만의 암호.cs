using System;

public class Solution {
    public string solution(string s, string skip, int index) {
        string alphabet = "abcdefghijklmnopqrstuvwxyz";
        int alphabetLength = 0;
        string result = string.Empty;

        foreach (char c in skip)
        {
            alphabet = alphabet.Replace(c.ToString(), "");
        }

        alphabetLength = alphabet.Length;

        foreach (char c in s)
        {
            int newIndex = (alphabet.IndexOf(c) + index) % alphabetLength;
            result += alphabet[newIndex];
        }
        return result;
    }
}