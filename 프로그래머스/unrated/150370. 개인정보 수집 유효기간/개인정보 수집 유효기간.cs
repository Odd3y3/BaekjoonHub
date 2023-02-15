using System;
using System.Collections.Generic;

public class Solution {
    private struct Date
    {
        public Date(int year, int month, int day)
        {
            this.year = year;
            this.month = month;
            this.day = day;
        }

        public int year;
        public int month;
        public int day;

    }
    private int CompareDates(Date date1, Date date2) // date1 > date2 이면 + , date1 < date2 이면 - , 같으면 0
    {
        if (date1.year != date2.year)
            return date1.year - date2.year;
        else if (date1.month != date2.month)
            return date1.month - date2.month;
        else if (date1.day != date2.day)
            return date1.day - date2.day;
        else
            return 0;
    }
    private Date ReduceDates(Date todayDate, int month)
    {
        todayDate.month -= month;
        while (todayDate.month <= 0)
        {
            todayDate.year--;
            todayDate.month += 12;
        }

        return todayDate;
    }
    private Date StringToDate(string date)
    {
        string[] arr = date.Split('.');
        int year = int.Parse(arr[0]);
        int month = int.Parse(arr[1]);
        int day = int.Parse(arr[2]);
        return new Date(year, month, day);
    }
    public int[] solution(string today, string[] terms, string[] privacies) {
        Dictionary<string, Date> termsDate = new Dictionary<string, Date>();
        List<int> resultList = new List<int>();
        Date todayDate = StringToDate(today);
        foreach (string s in terms)
        {
            string[] arr = s.Split(' ');
            Date date = ReduceDates(todayDate, int.Parse(arr[1]));
            termsDate.Add(arr[0], date);
        }

        for(int i = 0; i < privacies.Length; i++)
        {
            string[] arr = privacies[i].Split(' ');
            Date privaciesDate = StringToDate(arr[0]);
            Date termDate = termsDate[arr[1]];
            if (CompareDates(privaciesDate, termDate) <= 0)
                resultList.Add(i + 1);
        }
        return resultList.ToArray();
    }
}