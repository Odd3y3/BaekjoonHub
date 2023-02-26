using System;
using System.Linq;

namespace MyTestingField
{
    struct Time
    {
        public int M;
        public int SS;
        public int sss;
        public string Team;
        public Time(int M, int SS, int sss, string Team)
        {
            this.M = M;
            this.SS = SS;
            this.sss = sss;
            this.Team = Team;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Time[] arr = new Time[8];
            int[] scores = { 10, 8, 6, 5, 4, 3, 2, 1 };
            int redScore = 0;
            int blueScore = 0;
            for (int i = 0; i < 8; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                string team = input[1];
                int[] time = input[0].Split(':').Select(x => int.Parse(x)).ToArray();
                arr[i] = new Time(time[0], time[1], time[2], team);
            }
            arr = arr.OrderBy(x => x.sss).OrderBy(x => x.SS).OrderBy(x => x.M).ToArray();

            for(int i = 0; i < 8; i++)
            {
                if (arr[i].Team == "R")
                    redScore += scores[i];
                else
                    blueScore += scores[i];
            }

            if (redScore > blueScore)
                Console.WriteLine("Red");
            else
                Console.WriteLine("Blue");
        }
    }
}
