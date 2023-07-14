
namespace TestingField
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            List<int>[] childrenNodes = new List<int>[n];
            for(int i = 0; i < n; i++)
                childrenNodes[i] = new List<int>();
            bool[] deleteNode = new bool[n];
            for(int i = 0; i < n; i++)
            {
                if (arr[i] == -1)
                    continue;

                childrenNodes[arr[i]].Add(i);
            }

            //delete node
            int deleteNum = int.Parse(Console.ReadLine());
            if (arr[deleteNum] != -1)
                childrenNodes[arr[deleteNum]].Remove(deleteNum);
            DeleteNode(deleteNum, childrenNodes, deleteNode);


            //output
            int result = 0;
            for(int i = 0; i < n; i++)
            {
                if (!deleteNode[i] && childrenNodes[i].Count == 0)
                    result++;
            }
            Console.WriteLine(result);
        }
        static void DeleteNode(int num, List<int>[] childrenNodes, bool[] deleteNode)
        {
            deleteNode[num] = true;
            foreach(var item in childrenNodes[num])
            {
                DeleteNode(item, childrenNodes, deleteNode);
            }
        }
    }
}