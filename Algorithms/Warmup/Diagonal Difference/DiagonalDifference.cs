/*
    Question : https://www.hackerrank.com/challenges/diagonal-difference/problem    
*/

using System;
using static System.Console;

class DiagonalDifference
{
    static void Main(string[] args)
    {
        var sumOfFirstDiagonal = 0;
        var sumOfSecondDiagonal = 0;

        var nOfRows = int.Parse(ReadLine());

        for (int i = 0, j = nOfRows - 1; i < nOfRows; i++, j--)
        {
            var arr = ReadLine().Split(','); //Read rows
            var newRow = Array.ConvertAll(arr, int.Parse);
            sumOfFirstDiagonal += newRow[i];
            sumOfSecondDiagonal += newRow[j];
        }
        WriteLine(Math.Abs(sumOfFirstDiagonal - sumOfSecondDiagonal));
    }
}