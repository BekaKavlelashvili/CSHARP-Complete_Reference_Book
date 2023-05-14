using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class ArrayUtils
    {
        public static bool CopyInstert<T>(T e, uint idx, T[] src, T[] target)
        {
            if (target.Length > src.Length + 1)
                return false;

            for (int i = 0, j = 0; i < src.Length; i++, j++)
            {
                if (i == idx)
                {
                    target[j] = e;
                    j++;
                }
                target[j] = src[i];
            }
            return true;
        }
    }

    public static class GenericMethod
    {
        public static void GenericMethodMain()
        {
            Console.WriteLine("\n=== Generic Method ===");
            int[] nums = { 1, 2, 3 };
            int[] nums2 = new int[4];

            Console.Write("Display contents of nums: ");
            foreach (int num in nums)
                Console.Write(num + " ");

            Console.WriteLine();

            ArrayUtils.CopyInstert(99, 2, nums, nums2);

            Console.Write("Contens of nums2: ");
            foreach (int num in nums2)
                Console.Write(num + " ");

            Console.WriteLine();

            string[] strs = { "Generics", "are", "powerful." };
            string[] strs2 = new string[4];

            Console.Write("Contens of strs: ");
            foreach (string str in strs)
                Console.Write(str + " ");

            Console.WriteLine();

            ArrayUtils.CopyInstert("in C#", 1, strs, strs2);

            Console.Write("Contents of strs2: ");
            foreach (string str in strs2)
                Console.Write(str + " ");
        }
    }
}
