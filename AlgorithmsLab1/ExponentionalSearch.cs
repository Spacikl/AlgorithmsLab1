using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgLab1
{
    public static class ExponentionalSearch
    {
        public static (int, int) ExpSearch(int[][] matrix, int target)
        {
            var row = 0;
            var column = matrix[0].Length - 1;
            while(row < matrix.Length && column >= 0)
            {
                if (matrix[row][column] == target)
                    return (row, column);

                if (matrix[row][column] < target)
                    row++;

                else if (matrix[row][column] > target)
                {
                    
                    var start = 1;

                    while ((column - start) >= 0 && matrix[row][column - start] > target)
                        start *= 2;

                    start = Math.Max(column - start, 0);

                    column =  BinarySearch
                        .BinSearch(matrix[row], target, start, column);
                }
            }
            return (-1,-1);
        }
    }
}
