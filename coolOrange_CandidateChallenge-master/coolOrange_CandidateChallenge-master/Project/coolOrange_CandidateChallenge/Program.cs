using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coolOrange_CandidateChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[5] {2, 3, 5, 4, 1};
            Console.Write("int[] a = ");
            Array.printIntArray(a);
            Console.WriteLine("FindMaxValue(a, 0, 1): " + Array.FindMaxValue(a, 0, 1));
            Console.WriteLine("FindMinValue(a, 1, 3): " + Array.FindMinPosition(a, 1, 3));
            Array.Swap(a, 0, 2);
            Console.Write("Swap:  ");
            Array.printIntArray(a);
            Array.ShiftLeftByOne(a, 1, 4);
            Console.Write("ShiftLeftByOne:  ");
            Array.printIntArray(a);
            Console.WriteLine("CreateRandomArray(10, 1, 10): ");
            Array.printIntArray(Array.CreateRandomArray(10, 1, 10));
            Console.WriteLine("CreateRandomMatrix(5, 10, 1, 10): ");
            Array.printIntMatrix(Array.CreateRandomMatrix(5, 10, 1, 10));
            int[,] a1 = Array.CopyArray(a);
            Console.WriteLine("CopyArray(a): ");
            Array.printIntMatrix(a1);
            int[] a2 = new int[5] {1, 2, 3, 4, 5};
            Console.Write("int[] a2 = ");
            Array.printIntArray(a2);
            Console.WriteLine("FindInSortedArray(a2, 4) = " + Array.FindInSortedArray(a2, 4));
            Console.WriteLine("IsPalindrome(\"racecar\")" + PalindromeChecker.IsPalindrome("racecar"));
            Console.WriteLine("IsPalindrome(\"hello\")" + PalindromeChecker.IsPalindrome("hello"));






        }
    }
}
