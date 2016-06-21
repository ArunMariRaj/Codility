using System;
using System.Collections.Generic;
using System.Linq;

namespace Codility
{
    public class CodilityPractices
    {
       public static void Main()
    {
        PermCheckCodility();
    }
    /// <summary>
    /// A non-empty zero-indexed array A consisting of N integers is given.
    /// A permutation is a sequence containing each element from 1 to N once, and only once.
    /// For example, array A such that:
    ///  A[0] = 4
    ///  A[1] = 1
    ///  A[2] = 3
    ///  A[3] = 2
    /// is a permutation, but array A such that:
    ///  A[0] = 4
    ///  A[1] = 1
    ///  A[2] = 3
    /// is not a permutation, because value 2 is missing.
    /// The goal is to check whether array A is a permutation.
    /// Write a function:
    /// class Solution { public int solution(int[] A); }
    /// that, given a zero-indexed array A, returns 1 if array A is a permutation and 0 if it is not.
    /// For example, given array A such that:
    ///  A[0] = 4
    ///  A[1] = 1
    ///  A[2] = 3
    ///  A[3] = 2
    /// the function should return 1.
    /// Given array A such that:
    ///  A[0] = 4
    ///  A[1] = 1
    ///  A[2] = 3
    /// the function should return 0.
    /// Assume that:
    /// N is an integer within the range[1..100, 000];
    /// each element of array A is an integer within the range[1..1, 000, 000, 000].
    /// Complexity:
    /// expected worst-case time complexity is O(N);
    /// expected worst-case space complexity is O(N), beyond input storage(not counting the storage required for input arguments).
    /// Elements of input arrays can be modified.
    /// </summary>
    private static void PermCheckCodility()
    {
        int[] A = { 1,1 };
        //  Solution
        int max = A.Max();
        int startIndex = 0;
        int count = 0;
        if (max > A.Length + 1)
        {
            Console.WriteLine("0");
        }
        else
        {
            int[] arr = new int[max];
            while (startIndex < A.Length)
            {
                if (arr[A[startIndex] - 1] == 0)
                {
                    arr[A[startIndex] - 1]++;
                    count++;
                }
                else if (arr[A[startIndex] - 1] == 1)
                {
                    Console.WriteLine("0");
                    break;
                }
                startIndex++;
            }
            if (count == max)
            {
                Console.WriteLine("1");
            }
            else
                Console.WriteLine("0");
        }

    }
        /// <summary>
        /// A small frog wants to get to the other side of a river. The frog is initially located on one bank of the river (position 0) and wants to get to the opposite bank (position X+1). Leaves fall from a tree onto the surface of the river.
        /// You are given a zero-indexed array A consisting of N integers representing the falling leaves.A[K] represents the position where one leaf falls at time K, measured in seconds.
        /// The goal is to find the earliest time when the frog can jump to the other side of the river.The frog can cross only when leaves appear at every position across the river from 1 to X(that is, we want to find the earliest moment when all the positions from 1 to X are covered by leaves). You may assume that the speed of the current in the river is negligibly small, i.e.the leaves do not change their positions once they fall in the river.
        /// For example, you are given integer X = 5 and array A such that:
        ///  A[0] = 1
        ///  A[1] = 3
        ///  A[2] = 1
        ///  A[3] = 4
        ///  A[4] = 2
        ///  A[5] = 3
        ///  A[6] = 5
        ///  A[7] = 4
        /// In second 6, a leaf falls into position 5. This is the earliest time when leaves appear in every position across the river.
        /// Write a function:
        /// class Solution { public int solution(int X, int[] A); }
        /// that, given a non-empty zero-indexed array A consisting of N integers and integer X, returns the earliest time when the frog can jump to the other side of the river.
        /// If the frog is never able to jump to the other side of the river, the function should return −1.
        /// For example, given X = 5 and array A such that:
        ///  A[0] = 1
        ///  A[1] = 3
        ///  A[2] = 1
        ///  A[3] = 4
        ///  A[4] = 2
        ///  A[5] = 3
        ///  A[6] = 5
        ///  A[7] = 4
        /// the function should return 6, as explained above.
        /// Assume that:
        /// N and X are integers within the range [1..100,000];
        /// each element of array A is an integer within the range[1..X].
        /// Complexity:
        /// expected worst-case time complexity is O(N);
        /// expected worst-case space complexity is O(X), beyond input storage(not counting the storage required for input arguments).
        /// Elements of input arrays can be modified.
        /// </summary>
        private static void FrogJumpCodility()
        {
            int X = 5;
            int[] A = { 1, 3, 1, 4, 2, 3, 5, 4 };
        
            //Actual Solution
            int[] arr = new int[X];
            int count = 0;
            int i = 0;
            while(count<X && i<A.Length)
            {
                if (arr[A[i] - 1] == 0)
                {
                    arr[A[i] - 1] = 1;
                    count++;
                }
                i++;
            }
            if (count==X)
            {
                Console.WriteLine(--i);
            }
            else
            {
                Console.WriteLine("-1");
            }
        }
        /// <summary>                                                                 
        /// A zero-indexed array A consisting of N different integers is given. 
        /// The array contains integers in the range [1..(N + 1)], which means that exactly one element is missing. /// Your goal is to find that missing element. 
        /// Write a function: 
        /// class Solution { public int solution(int[] A); } 
        /// that, given a zero-indexed array A, returns the value of the missing element.
        /// For example, given array A such that:
        /// A[0] = 2
        /// A[1] = 3
        /// A[2] = 1 
        /// A[3] = 5 
        /// the function should return 4, as it is the missing element. 
        /// Assume that: 
        /// N is an integer within the range[0..100, 000]; 
        /// the elements of A are all distinct; 
        /// each element of array A is an integer within the range[1..(N + 1)]. 
        /// Complexity: 
        /// expected worst-case time complexity is O(N); 
        /// expected worst-case space complexity is O(1), beyond input storage(not counting the storage required for input arguments). 
        /// Elements of input arrays can be modified. 
        /// </summary>
        private static void MissingElementinanArrayCodility()
        {
            int[] A = { 2, 3, 1, 5 };
            int sum = 0;
            for (int i = 0; i < A.Length + 1; i++)
            {
                sum += i + 1;
            }
            Console.WriteLine(sum);
            for (int i = 0; i < A.Length; i++)
            {
                sum -= A[i];
            }
            Console.WriteLine(sum);
        }
        /// <summary>
        /// A non-empty zero-indexed array A consisting of N integers is given. Array A represents numbers on a tape.
        /// Any integer P, such that 0 < P<N
        /// splits this tape into two non-empty parts: 
        /// A[0], A[1], ..., A[P − 1] and A[P], A[P + 1], ..., A[N − 1].
        /// The difference between the two parts is the value of: 
        /// |(A[0] + A[1] + ... + A[P − 1]) − (A[P] + A[P + 1] + ... + A[N − 1])|
        /// In other words, it is the absolute difference between the sum of the first part and the sum of the second part.
        /// For example, consider array A such that:
        /// A[0] = 3
        /// A[1] = 1
        /// A[2] = 2
        /// A[3] = 4
        /// A[4] = 3
        /// We can split this tape in four places:
        /// P = 1, difference = | 3 − 10| = 7 
        /// P = 2, difference = | 4 − 9| = 5 
        /// P = 3, difference = | 6 − 7| = 1 
        /// P = 4, difference = | 10 − 3| = 7 
        /// Write a function:
        /// class Solution { public int solution(int[] A); }
        /// that, given a non-empty zero-indexed array A of N integers, returns the minimal difference that can be achieved.
        /// For example, given:
        /// A[0] = 3
        /// A[1] = 1
        /// A[2] = 2
        /// A[3] = 4
        /// A[4] = 3
        /// the function should return 1, as explained above.
        /// Assume that:
        /// N is an integer within the range[2..100, 000];
        /// each element of array A is an integer within the range[−1, 000..1, 000].
        /// Complexity:
        /// expected worst-case time complexity is O(N);
        /// expected worst-case space complexity is O(N), beyond input storage(not counting the storage required for input arguments).
        /// Elements of input arrays can be modified.
        /// </summary>
        private static void TapeEquillibriumCodility()
        {
            int[] A = { 1, 1 };
            int totalSum = 0;
            for (int i = 0; i < A.Length; i++)
            {
                totalSum += A[i];
            }
            int min = int.MaxValue;
            int LHS = 0;
            for (int i = 0; i < A.Length - 1; i++)
            {
                LHS += A[i];
                int RHS = totalSum - LHS;
                int temp = Math.Abs(RHS - LHS);
                if (temp < min)
                {
                    min = temp;
                }
            }
            Console.WriteLine(min);
        }
        /// <summary>
        /// A small frog wants to get to the other side of the road. The frog is currently located at position X and wants to get to a position greater than or equal to Y. The small frog always jumps a fixed distance, D.
        /// Count the minimal number of jumps that the small frog must perform to reach its target.
        /// Write a function:
        /// int solution(int X, int Y, int D);
        /// that, given three integers X, Y and D, returns the minimal number of jumps from position X to a position equal to or greater than Y.
        /// For example, given:
        /// X = 10
        /// Y = 85
        /// D = 30
        /// the function should return 3, because the frog will be positioned as follows:
        /// after the first jump, at position 10 + 30 = 40
        /// after the second jump, at position 10 + 30 + 30 = 70
        /// after the third jump, at position 10 + 30 + 30 + 30 = 100
        /// Assume that:
        /// X, Y and D are integers within the range[1..1, 000, 000, 000];
        /// X ≤ Y.
        /// Complexity:
        /// expected worst-case time complexity is O(1);
        /// expected worst-case space complexity is O(1).
        /// </summary>
        private static void FrogJumpsCodility()
        {

            int X = 10;
            int Y = 85;
            int D = 30;
            Console.WriteLine((Y - X) % D == 0 ? (Y - X) / D : ((Y - X) / D) + 1);
        }
        /// <summary>
        ///  A non-empty zero-indexed array A consisting of N integers is given. The array contains an odd number of elements, and each element of the array can be paired with another element that has the same value, except for one element that is left unpaired.
        ///  For example, in array A such that:
        ///  A[0] = 9  A[1] = 3  A[2] = 9
        ///  A[3] = 3  A[4] = 9  A[5] = 7
        ///  A[6] = 9
        ///  the elements at indexes 0 and 2 have value 9,
        ///  the elements at indexes 1 and 3 have value 3,
        ///  the elements at indexes 4 and 6 have value 9,
        ///  the element at index 5 has value 7 and is unpaired.
        ///  Write a function:
        ///  class Solution { public int solution(int[] A); }
        ///  that, given an array A consisting of N integers fulfilling the above conditions, returns the value of the unpaired element.
        ///  For example, given array A such that:
        ///  A[0] = 9  A[1] = 3  A[2] = 9
        ///  A[3] = 3  A[4] = 9  A[5] = 7
        ///  A[6] = 9
        ///  the function should return 7, as explained in the example above.
        ///  Assume that:
        ///  N is an odd integer within the range [1..1,000,000];
        ///  each element of array A is an integer within the range[1..1, 000, 000, 000];
        ///  all but one of the values in A occur an even number of times.
        ///  Complexity:
        ///  expected worst-case time complexity is O(N);
        ///  expected worst-case space complexity is O(1), beyond input storage(not counting the storage required for input arguments).
        ///  Elements of input arrays can be modified.
        /// </summary>
        private static void FindUnpairedNumberinArrayCodility()
        {
            int[] A = { 9, 3, 9, 3, 5 };
            int N = 5;
            Dictionary<int, int> dict = new Dictionary<int, int>();
            for (int i = 0; i < N; i++)
            {

                if (dict.ContainsKey(A[i]))
                {
                    dict[A[i]] += 1;
                }
                else
                {
                    dict.Add(A[i], 1);
                }
            }
            foreach (var item in dict.Keys)
            {
                if (dict[item] % 2 == 1)
                {
                    Console.WriteLine(dict[item]);
                }
            }

        }
        /// <summary>
        /// A zero-indexed array A consisting of N integers is given. Rotation of the array means that each element is shifted right by one index, and the last element of the array is also moved to the first place.
        /// For example, the rotation of array A = [3, 8, 9, 7, 6] is [6, 3, 8, 9, 7]. The goal is to rotate array A K times; that is, each element of A will be shifted to the right by K indexes.
        /// Write a function:
        /// class Solution { public int[] solution(int[] A, int K); }
        /// that, given a zero-indexed array A consisting of N integers and an integer K, returns the array A rotated K times.
        /// For example, given array A = [3, 8, 9, 7, 6] and K = 3, the function should return [9, 7, 6, 3, 8].
        /// Assume that:
        /// N and K are integers within the range[0..100];
        /// each element of array A is an integer within the range[−1, 000..1, 000].
        /// In your solution, focus on correctness.The performance of your solution will not be the focus of the assessment.
        /// </summary>
        private static void CyclicRotationOfArrayCodility()
        {
            int K = int.Parse(Console.ReadLine());
            int[] arr = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            int count = arr.Length - 1;
            if (count >= 0)
            {
                List<int> arrList = arr.ToList();
                for (int i = 0; i < K; i++)
                {
                    int temp = arrList[count];
                    arrList.RemoveAt(count);
                    arrList.Insert(0, temp);
                }
                int[] modifiedArray = arrList.ToArray();
                foreach (var item in modifiedArray)
                {
                    Console.WriteLine(item);
                }
            }
        }
        /// <summary>
        /// A binary gap within a positive integer N is any maximal sequence of consecutive zeros that is surrounded by ones at both ends in the binary representation of N.
        /// For example, number 9 has binary representation 1001 and contains a binary gap of length 2. The number 529 has binary representation 1000010001 and contains two binary gaps: one of length 4 and one of length 3. The number 20 has binary representation 10100 and contains one binary gap of length 1. The number 15 has binary representation 1111 and has no binary gaps.
        /// Write a function:
        /// class Solution { public int solution(int N); }
        /// that, given a positive integer N, returns the length of its longest binary gap.The function should return 0 if N doesn't contain a binary gap.
        /// For example, given N = 1041 the function should return 5, because N has binary representation 10000010001 and so its longest binary gap is of length 5.
        /// Assume that:
        /// N is an integer within the range[1..2, 147, 483, 647].
        /// Complexity:
        /// expected worst-case time complexity is O(log(N));
        /// expected worst-case space complexity is O(1).
        /// </summary>
        private static void BinaryGapCodility()
        {
            int N = int.Parse(Console.ReadLine());
            string str = Convert.ToString(N, 2);
            int currIndex = 0;
            int maxIndex = str.Length - 1;
            int preIndex = 0;
            int maxLength = 0;
            int curLength = 0;
            int tempIndex = 0;
            while (tempIndex <= maxIndex)
            {
                preIndex = currIndex;
                currIndex = str.IndexOf('1', tempIndex);
                if (currIndex == -1)
                {
                    break;
                }
                curLength = currIndex - preIndex;
                if (curLength > maxLength)
                    maxLength = curLength;
                tempIndex = currIndex + 1;
            }
            Console.WriteLine(maxLength = maxLength == 0 ? maxLength : maxLength - 1);
        }
    }
}
