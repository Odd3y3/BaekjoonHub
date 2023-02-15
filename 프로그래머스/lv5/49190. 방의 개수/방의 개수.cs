using System;
using System.Collections.Generic;

public class Solution {
    struct Point
    {
        public int x;
        public int y;
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
    public int solution(int[] arrows) {
        Dictionary<Point, List<Point>> edgeDict = new Dictionary<Point, List<Point>>();
        Point presentPoint = new Point(0, 0);
        Point nextPoint = new Point(0, 0);
        edgeDict[presentPoint] = new List<Point>();
        int result = 0;

        foreach (int arrow in arrows)
        {
            switch (arrow)
            {
                case 0:
                    nextPoint = new Point(presentPoint.x, presentPoint.y + 1);
                    break;
                case 1:
                    nextPoint = new Point(presentPoint.x + 1, presentPoint.y + 1);
                    break;
                case 2:
                    nextPoint = new Point(presentPoint.x + 1, presentPoint.y);
                    break;
                case 3:
                    nextPoint = new Point(presentPoint.x + 1, presentPoint.y - 1);
                    break;
                case 4:
                    nextPoint = new Point(presentPoint.x, presentPoint.y - 1);
                    break;
                case 5:
                    nextPoint = new Point(presentPoint.x - 1, presentPoint.y - 1);
                    break;
                case 6:
                    nextPoint = new Point(presentPoint.x - 1, presentPoint.y);
                    break;
                case 7:
                    nextPoint = new Point(presentPoint.x - 1, presentPoint.y + 1);
                    break;
            }

            if (!edgeDict[presentPoint].Contains(nextPoint))
            {
                if (edgeDict.ContainsKey(nextPoint))
                    result++;
                else
                    edgeDict[nextPoint] = new List<Point>();

                if (edgeDict.ContainsKey(new Point(presentPoint.x, nextPoint.y)) &&
                    edgeDict[new Point(presentPoint.x, nextPoint.y)].Contains(new Point(nextPoint.x, presentPoint.y)))
                    result++;


                edgeDict[presentPoint].Add(nextPoint);
                edgeDict[nextPoint].Add(presentPoint);
            }

            presentPoint = nextPoint;
        }
        return result;
    }
}