using System.Xml.Schema;

namespace Assignment6._2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var stack = new ArrayStack();
            stack.Push(10);
            stack.Push(20);
            Console.WriteLine("Stack top: " + stack.Peek());
            Console.WriteLine("Popped item: " + stack.Pop());

            int[] testArray = { 1, 2, 3, 4 };
            int[] secondTestArray = { -1, 1, 0, -3, 3 };

            int[] result1 = ProductExceptSelf(testArray);
            Console.WriteLine("Product Except Self (first): " + string.Join(", ", result1));

            int[] result2 = ProductExceptSelf(secondTestArray);
            Console.WriteLine("Product Except Self (second): " + string.Join(", ", result2));

        }
        static int[] ProductExceptSelf(int[] nums)
        {
            int n = nums.Length;
            int[] answer = new int[n];

            // left/prefix products
            int left = 1;
            for (int i = 0; i < n; i++)
            {
                answer[i] = left;
                left *= nums[i];
            }

            // right/suffix products
            int right = 1;
            for (int i = n - 1; i >= 0; i--)
            {
                answer[i] *= right;
                right *= nums[i];
            }

            return answer;
        }
    }
}
