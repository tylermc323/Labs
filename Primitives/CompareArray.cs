using System;
using System.Linq;
using System.Collections.Generic;

namespace Primitives
{
    public class CompareArray
    {
        public static int[] ArrayDiff(int[] a, int[] b)
        {
            // Codewars Kata: https://www.codewars.com/kata/523f5d21c841566fde000009/train/csharp

            //Solution

            var bSet = new HashSet<int>(b);
            return a.Where(x => !bSet.Contains(x)).ToArray();

        }
    }
}
