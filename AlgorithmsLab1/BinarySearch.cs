using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AlgLab1
{
    public static class BinarySearch
    {
        public static int BinSearch(int[] row, int target, int left = 0, int right = 0)
        {
            if (left == 0 && right == 0)
                right = row.Length - 1;
            
            while (left <= right)
            {
                var middle = (left + right) / 2;

                if (row[middle] == target)
                    return middle;

                if (target < row[middle])
                    right = middle - 1;

                else left = middle + 1;
            }
            return right;
        }
    }
}
