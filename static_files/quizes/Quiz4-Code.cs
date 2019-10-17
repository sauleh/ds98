using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS98
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 5, 3, 1, 2, 9, 6, 11, 8, 10, 7, 4 };

            Console.WriteLine("digraph G {");
            QuickSort_TailRecursion(nums, 0, nums.Length - 1, "root");
            Console.WriteLine("}");

            Console.WriteLine("digraph G {");
            QuickSort_Normal(nums, 0, nums.Length - 1, "root");
            Console.WriteLine("}");

            // Then visualize the call graph using http://www.webgraphviz.com
        }

        private static void QuickSort_Normal(int[] nums, int l, int r, string father)
        {
            if (l < r)
            {
                int m = Parition(nums, l, r);
                #region Printing Output
                string me = string.Join(" ", nums.Where((n, i) => (i >= l) && (i <= r)));
                Console.WriteLine($"\"[{father}]\" -> \"[{me}]\";");
                #endregion
                QuickSort_Normal(nums, l, m - 1, me);
                QuickSort_Normal(nums, m + 1, r, me);
            }
        }


        private static void QuickSort_TailRecursion(int[] nums, int l, int r, string father)
        {
            string me;
            #region Printing Output
            if (l == r)
            {
                me = string.Join(" ", nums.Where((n, i) => (i >= l) && (i <= r)));
                Console.WriteLine($"\"[{father}]\" -> \"[{me}]\";");
            }
            #endregion

            while (l < r)
            {
                #region Printing Output
                me = string.Join(" ", nums.Where((n, i) => (i >= l) && (i <= r)));
                Console.WriteLine($"\"[{father}]\" -> \"[{me}]\";");
                #endregion

                int m = Parition(nums, l, r);
                if ( (m-l) < (r-m) ) // Left side is smaller
                {
                    QuickSort_TailRecursion(nums, l, m - 1, me);
                    l = m + 1;
                }
                else // Right side is smaller
                {
                    QuickSort_TailRecursion(nums, m + 1, r, me);
                    r = m - 1;
                }
            }
        }

        private static int Parition(int[] A, int l, int r)
        {
            // To make sure the partition is done exactly as we
            // explained in class, I'm creating a new array p,
            // doing the partioning in this array and then  copying
            // the results back into A.
            int[] p = new int[r - l + 1];
            int newArrayCounter = 0;
            for(int i=l+1; i<=r; i++)
            {
                if (A[i] < A[l])
                    p[newArrayCounter++] = A[i];
            }

            int pivot = l + newArrayCounter;
            p[newArrayCounter++] = A[l];

            for (int i = l + 1; i <= r; i++)
            {
                if (A[i] > A[l])
                    p[newArrayCounter++] = A[i];
            }

            for (int i = 0; i < p.Length; i++)
                A[l + i] = p[i];

            return pivot;
        }
    }
}
