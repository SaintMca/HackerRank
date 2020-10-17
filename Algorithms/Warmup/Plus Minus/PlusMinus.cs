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
        var positiveNumbers = 0;
        var negativeNumbers = 0;
        var zeroNumbers = 0;
        
        var temp_arr = ReadLine().Split(',');
        var arr = Array.ConvertAll(temp_arr, Int32.Parse);

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] > 0)
                ++positiveNumbers;
            else if (arr[i] < 0)
                ++negativeNumbers;
            else
                ++zeroNumbers;
        }

        WriteLine((double)positiveNumbers / arr.Length);  //We use double here because of explanation "The test cases are scaled to six decimal places" 
        WriteLine((double)negativeNumbers / arr.Length);
        WriteLine((double)zeroNumbers / arr.Length);
        ReadLine();
    }
}