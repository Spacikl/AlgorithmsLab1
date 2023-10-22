using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgLab1
{
    public static  class LadderSearch
    {
        public static (int,int) LadSearch(int[][] matrix, int target)
        {
            var column = matrix[0].Length - 1;
            var row = 0;

            while (column >= 0 && row < matrix.Length)
            {
                if (matrix[row][column] == target)
                    return (row,column);

                if (matrix[row][column] > target)
                    column--;

                else if (matrix[row][column] < target) 
                    row++;
            }
            return (-1,-1);
        }
    }
}
