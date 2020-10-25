/*
    Question : https://www.hackerrank.com/challenges/staircase/problem      
                
*/

using System;
using static System.Console;

class Staircase
{
    #region Given in Question
    // Complete the staircase function below.
    static void staircase(int n)
    {
        for (int i = 1; i <= n; i++)
        {
            var spaces = new String(' ', n - i);
            var numberSign = new String('#', i);
            Console.WriteLine(spaces + numberSign);
        }
    }
    static void Main(String[] args)
    {      
        int n = Convert.ToInt32(Console.ReadLine());
        staircase(n);
    }
    #endregion
}