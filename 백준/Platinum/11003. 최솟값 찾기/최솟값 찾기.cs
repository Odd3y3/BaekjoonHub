
using System.Text;

namespace TestingField
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Stopwatch stopwatch = new Stopwatch();
            //stopwatch.Start();

            //StreamReader sr = new StreamReader("Input1.txt");
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            //StreamWriter sw = new StreamWriter("Output1.txt");

            string[] input = sr.ReadLine().Split();


            int N = int.Parse(input[0]);
            int L = int.Parse(input[1]);


            int[] A = sr.ReadLine().Split().Select(int.Parse).ToArray();

            

            StringBuilder answer = new StringBuilder();
            Deque deque = new Deque();

            for (int i = 0; i < A.Length; i++)
            {
                //맨 앞에꺼 빼기
                if (i >= L && !deque.isEmpty())
                {
                    if(i - L == deque.PeekFirst().Item2)
                        deque.DequeueFirst();
                }

                //다음거 추가
                while (!deque.isEmpty() && deque.PeekLast().Item1 > A[i])
                {
                    deque.DequeueLast();
                }
                deque.EnqueueLast((A[i], i));

                //최소값 ( 큐의 제일 앞에 값 )
                //answer.Append(deque.PeekFirst().Item1);
                //if (i != A.Length - 1)
                //    answer.Append(" ");
                sw.Write(deque.PeekFirst().Item1);
                if(i != A.Length - 1)
                    sw.Write(' ');
            }


            //Console.WriteLine(answer);

            //stopwatch.Stop();
            //Console.WriteLine();
            //Console.WriteLine(stopwatch.ElapsedMilliseconds);

            sr.Close();
            sw.Close();
        }

        
    }

    class Deque
    {
        private int startIndex = 0;
        private int endIndex = -1;

        //private List<(int, int)> queue = new List<(int, int)>();
        private (int, int)[] queue = new (int, int)[5000001];


        public bool isEmpty()
        {
            if (startIndex > endIndex) return true;
            else return false;
        }

        public void EnqueueLast((int, int) value)
        {
            endIndex++;
            //if (endIndex == queue.Count)
            //    queue.Add(value);
            //else
            //    queue[endIndex] = value;
            queue[endIndex] = value;
        }

        public (int, int) DequeueFirst()
        {
            var value = queue[startIndex];
            startIndex++;
            return value;
        }

        public (int, int) DequeueLast()
        {
            var value = queue[endIndex];
            endIndex--;
            return value;
        }

        public (int, int) PeekFirst()
        {
            return queue[startIndex];
        }

        public (int, int) PeekLast()
        {
            return queue[endIndex];
        }
    }
}

