using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace coolOrange_CandidateChallenge
{
    public class Array
    {
        public static void printIntArray(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i]);
                if (i != a.Length - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine();
        }

        public static void printIntMatrix(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for(int i1 = 0; i1 < a.GetLength(1); i1++)
                {
                    Console.Write(a[i, i1]);
                    if (i != a.Length - 1)
                    {
                        Console.Write(", ");
                    }
                }
                if (i + 1 < a.GetLength(0))
                {
                    Console.WriteLine();
                }
            }
            Console.WriteLine();
        }


        public static int FindMaxValue(int[] array, int position1, int position2)
        {
            int ret;
            if (position1 < 0 || position2 < 0 || position2 < position1)
                {
                ret = -1;
                return ret;
            }
            else
            {
                ret = array[position1];
                for (int i = position1 + 1; i <= position2; i++)
                {
                    if (array[i] > ret)
                    {
                        ret = array[i];
                    }
                }
                return ret;
            }
        }	

        public static int FindMinPosition(int[] array, int position1, int position2)
        {
            int ret;
            if (position1 < 0 || position2 < 0 || position2 < position1 || position1 >= array.Length || position2 >= array.Length)
            {
                ret = -1;
                return ret;
            }
            else
            {
                ret = position1;
                for (int i = position1 + 1; i < position2; i++)
                {
                    if (array[i] < array[ret])
                    {
                        ret = i;
                    }
                }
                return ret;
            }
        }

        public static void Swap(int[] array, int position1, int position2)
        {
            if (position1 < 0 || position2 < 0 || position1 >= array.Length || position2 >= array.Length)
            {
                Console.WriteLine("beide Positionen muessen im Array enthalten sein");
            }
            else
            {
                (array[position1], array[position2]) = (array[position2], array[position1]);
            }
        }

        public static void ShiftLeftByOne(int[] array, int position1, int position2)
        {
            if (position1 < 0 || position2 < 0 || position1 >= array.Length || position2 >= array.Length || position2 < position1)
            {
                Console.WriteLine("beide Positionen muessen im Array enthalten sein");
            }
            else
            {
                for(int i = position1; i < position2 - 1; i++)
                {
                    (array[i], array[i + 1]) = (array[i + 1], array[i]);
                }
            }


        }

        public static int[] CreateRandomArray(int size, int minValue, int maxValue)
        {
            int[] ret = new int[size];
            Random rnd = new Random();
            for(int i = 0; i < size; i++)
            {
                ret[i] = rnd.Next(minValue, maxValue);
            }
            return ret;
        }

        public static int[,] CreateRandomMatrix(int rows, int columns, int minValue, int maxValue)
        {
            int[,] ret = new int[rows, columns];
            Random rnd = new Random();
            for(int i = 0; i < rows; i++)
            {
                for(int i1 = 0; i1 < columns; i1++)
                {
                    ret[i, i1] = rnd.Next(minValue, maxValue);
                }
            }
            return ret;
        }

        public static int[,] CopyArray(int[] array)
        {
            int[,] ret = new int[2, array.Length];
            for(int i = 0; i < 2; i++)
            {
                for(int i1 = 0; i1 < array.Length; i1++)
                {
                    ret[i, i1] = array[i1];
                }
            }
            return ret;
        }

        public static int FindInSortedArray(int[] array, int number)
        {
            int left = 0;
            int right = array.Length - 1;

            while (left <= right)
            {
                int ret = (left + right) / 2;
                if (array[ret] == number)
                {
                    return ret;
                }
                else if (array[ret] < number)
                {
                    left = ret + 1;
                }
                else
                {
                    right = ret - 1;
                }
            }

            return -1;
        }



    }
}
