using System;
using System.Text;

namespace MyTestingField
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            string[] input = Console.ReadLine().Split(' ');
            int n = int.Parse(input[0]);
            int m = int.Parse(input[1]);
            int length = n * m;
            length = length % 2 == 0 ? length : length - 1;
            Console.WriteLine(length);

            if(m % 2 == 0)
            {
                sb.AppendLine("1 1");
                bool isDown = true;
                for(int i = 1; i <= m; i++)
                {
                    if (isDown)
                    {
                        for (int j = 2; j <= n; j++)
                        {
                            sb.Append(j);
                            sb.Append(' ');
                            sb.AppendLine(i.ToString());
                        }
                        isDown = false;
                    }
                    else
                    {
                        for(int j = n; j >= 2; j--)
                        {
                            sb.Append(j);
                            sb.Append(' ');
                            sb.AppendLine(i.ToString());
                        }
                        isDown = true;
                    }
                }
                for(int i = m; i >= 2; i--)
                {
                    sb.Append("1 ");
                    sb.AppendLine(i.ToString());
                }
            }
            else if (n % 2 == 0)
            {
                sb.AppendLine("1 1");
                bool isDown = true;
                for (int i = 1; i <= n; i++)
                {
                    if (isDown)
                    {
                        for (int j = 2; j <= m; j++)
                        {
                            sb.Append(i);
                            sb.Append(' ');
                            sb.AppendLine(j.ToString());
                        }
                        isDown = false;
                    }
                    else
                    {
                        for (int j = m; j >= 2; j--)
                        {
                            sb.Append(i);
                            sb.Append(' ');
                            sb.AppendLine(j.ToString());
                        }
                        isDown = true;
                    }
                }
                for (int i = n; i >= 2; i--)
                {
                    sb.Append(i);
                    sb.AppendLine(" 1");
                }
            }
            else
            {
                sb.AppendLine("1 1");
                bool isDown = true;
                for (int i = 1; i <= m - 2; i++)
                {
                    if (isDown)
                    {
                        for (int j = 2; j <= n; j++)
                        {
                            sb.Append(j);
                            sb.Append(' ');
                            sb.AppendLine(i.ToString());
                        }
                        isDown = false;
                    }
                    else
                    {
                        for (int j = n; j >= 2; j--)
                        {
                            sb.Append(j);
                            sb.Append(' ');
                            sb.AppendLine(i.ToString());
                        }
                        isDown = true;
                    }
                }
                sb.Append(n);
                sb.Append(" ");
                sb.AppendLine((m - 1).ToString());
                for(int i = n - 1; i > 1; i--)
                {
                    if(i % 2 == 0)
                    {
                        sb.Append(i);
                        sb.Append(" ");
                        sb.AppendLine((m - 1).ToString());
                        sb.Append(i);
                        sb.Append(" ");
                        sb.AppendLine(m.ToString());
                    }
                    else
                    {
                        sb.Append(i);
                        sb.Append(" ");
                        sb.AppendLine(m.ToString());
                        sb.Append(i);
                        sb.Append(" ");
                        sb.AppendLine((m - 1).ToString());
                    }
                }
                for(int i = m; i > 1; i--)
                {
                    sb.Append("1 ");
                    sb.AppendLine(i.ToString());
                }
            }
            Console.WriteLine(sb);
        }
    }
}
