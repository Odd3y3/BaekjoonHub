
namespace TestingField
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] inOrder = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] postOrder = Console.ReadLine().Split().Select(int.Parse).ToArray();
            List<int> preOrder = new List<int>();
            Func(0, n - 1, 0, n - 1, inOrder, postOrder, preOrder);
            foreach (var item in preOrder)
            {
                Console.WriteLine(item);
            }
        }
        static void Func(int postStart, int postEnd, int inStart, int inEnd, int[] inOrder, int[] postOrder, List<int> preOrder)
        {
            int root = postOrder[postEnd];
            preOrder.Add(root);
            int rootIndex = Array.IndexOf(inOrder, root);
            int leftCount = rootIndex - inStart;
            if (leftCount > 0)
                Func(postStart, postStart + leftCount - 1, inStart, rootIndex - 1, inOrder, postOrder, preOrder);
            int rightCount = inEnd - rootIndex;
            if(rightCount > 0)
                Func(postStart + leftCount, postEnd - 1, rootIndex + 1, inEnd, inOrder, postOrder, preOrder);

        }
    }
}