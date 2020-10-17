/*
    Question : https://www.hackerrank.com/challenges/plus-minus/problem   

    Given an array of integers, calculate the ratios of its elements that are positive, negative, and zero. Print the decimal value of each fraction on a new line with 6 places after the decimal.

    Note: This challenge introduces precision problems. The test cases are scaled to six decimal places, though answers with absolute error of up to 10^-4  are acceptable.

*/

using System;
using static System.Console;

class PlusMinus
{
    static void Main(String[] args)
    {
        #region Given part by HackerRank
        int n = Convert.ToInt32(Console.ReadLine());
        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
        plusMinus(arr);
        #endregion          
    }

    static void plusMinus(int[] arr)
    {
        var positiveNumbers = 0;
        var negativeNumbers = 0;
        var zeroNumbers = 0;


        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] > 0)
                ++positiveNumbers;
            else if (arr[i] < 0)
                ++negativeNumbers;
            else
                ++zeroNumbers;
        }

        Console.WriteLine((double)positiveNumbers / arr.Length);
        Console.WriteLine((double)negativeNumbers / arr.Length);
        Console.WriteLine((double)zeroNumbers / arr.Length);
        ReadLine();

    }   
}