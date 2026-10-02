using System.Collections;

namespace Assignment1
{
    class Program
    {
        // Q1
        static void BubbleSort(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                bool swapped = false;

                for (int j = 0; j < arr.Length - 1 - i; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                        swapped = true;
                    }
                }

                // no swaps means its already sorted, so stop
                if (!swapped)
                    break;
            }
        }

        // Q3
        static void ReverseList(ArrayList list)
        {
            int left = 0;
            int right = list.Count - 1;

            while (left < right)
            {
                object temp = list[left];
                list[left] = list[right];
                list[right] = temp;
                left++;
                right--;
            }
        }

        // Q4
        static List<int> GetEvenNumbers(List<int> numbers)
        {
            List<int> result = new List<int>();

            foreach (int n in numbers)
            {
                if (n % 2 == 0)
                    result.Add(n);
            }

            return result;
        }

        // Q6
        static int FirstNonRepeated(string s)
        {
            Dictionary<char, int> count = new Dictionary<char, int>();

            foreach (char c in s)
            {
                if (count.ContainsKey(c))
                    count[c]++;
                else
                    count[c] = 1;
            }

            for (int i = 0; i < s.Length; i++)
            {
                if (count[s[i]] == 1)
                    return i;
            }

            return -1;
        }

        static void Main(string[] args)
        {
            // Q1
            Console.WriteLine("---- Q1 ----");
            int[] arr = { 5, 1, 4, 2, 8 };
            BubbleSort(arr);
            Console.WriteLine(string.Join(" ", arr));

            // Q2
            Console.WriteLine("---- Q2 ----");
            Range<int> range = new Range<int>(10, 20);
            Console.WriteLine(range.IsInRange(15));   // True
            Console.WriteLine(range.IsInRange(25));   // False
            Console.WriteLine(range.Length());        // 10

            // Q3
            Console.WriteLine("---- Q3 ----");
            ArrayList list = new ArrayList() { 1, 2, 3, 4, 5 };
            ReverseList(list);
            foreach (var item in list)
                Console.Write(item + " ");
            Console.WriteLine();

            // Q4
            Console.WriteLine("---- Q4 ----");
            List<int> nums = new List<int>() { 1, 2, 3, 4, 5, 6 };
            List<int> evens = GetEvenNumbers(nums);
            Console.WriteLine(string.Join(" ", evens));

            // Q5
            Console.WriteLine("---- Q5 ----");
            FixedSizeList<int> fixedList = new FixedSizeList<int>(2);
            fixedList.Add(10);
            fixedList.Add(20);
            Console.WriteLine(fixedList.Get(1));

            try
            {
                fixedList.Add(30);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                fixedList.Get(5);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            // Q6
            Console.WriteLine("---- Q6 ----");
            Console.WriteLine(FirstNonRepeated("leetcode"));   // 0
            Console.WriteLine(FirstNonRepeated("aabb"));       // -1
        }
    }
}
