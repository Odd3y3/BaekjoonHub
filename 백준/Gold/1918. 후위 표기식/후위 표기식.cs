
using System.Text;

namespace TestingField
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Console.WriteLine(Func(input));
        }
        static string Func(string input)
        {
            List<string> list = new List<string>();
            int length = input.Length;
            int index = 0;
            while(index < length){
                if (input[index] == '(')
                {
                    int openIndex = index;
                    int count = 0;
                    while (true)
                    {
                        index++;
                        if (input[index] == '(')
                            count++;
                        else if (input[index] == ')')
                        {
                            if (count != 0)
                                count--;
                            else
                            {
                                list.Add(Func(input.Substring(openIndex + 1, index - openIndex - 1)));
                                break;
                            }
                        }
                    }
                }
                else
                {
                    list.Add(input[index].ToString());
                }
                index++;
            }

            StringBuilder sb = new StringBuilder();
            string prevAddOper = "";
            string prevMulOper = "";
            foreach (var item in list)
            {
                if(item == "+" || item == "-")
                {
                    sb.Append(prevMulOper);
                    prevMulOper = "";
                    sb.Append(prevAddOper);
                    prevAddOper = item;
                }
                else if(item == "*" || item == "/")
                {
                    sb.Append(prevMulOper);
                    prevMulOper = item;
                }
                else
                {
                    sb.Append(item);
                }
            }
            sb.Append(prevMulOper);
            sb.Append(prevAddOper);


            return sb.ToString();
        }
    }
}