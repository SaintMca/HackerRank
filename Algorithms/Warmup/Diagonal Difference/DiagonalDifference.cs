/*
    Question : https://www.hackerrank.com/challenges/diagonal-difference/problem    
*/

using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;


class DiagonalDifference
{
    static void Main(string[] args)
    {
        #region Given Part
        int nOfRows = Convert.ToInt32(Console.ReadLine().Trim()); 

        List<List<int>> arr = new List<List<int>>();

        for (int i = 0; i < nOfRows; i++)
        {
            arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
        }

        int result = Result.diagonalDifference(arr, nOfRows);

        Console.WriteLine(result);
        ReadLine();
        #endregion
        
    }
}

class Result
{
    /*
     * Complete the 'diagonalDifference' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts 2D_INTEGER_ARRAY arr as parameter.
     */
    public static int diagonalDifference(List<List<int>> arr, int nOfRows)
    {
        var sumOfFirstDiagonal = 0;
        var sumOfSecondDiagonal = 0;

        int k = 0;
       
            for (int i = 0, j = nOfRows - 1; i < nOfRows; i++, j--)
            {

                sumOfFirstDiagonal += arr[k][i];
                sumOfSecondDiagonal += arr[k][j];
            if (k < nOfRows)
                k += 1;
            else
                break;
            }
        
        return Math.Abs(sumOfFirstDiagonal - sumOfSecondDiagonal);
    }
}