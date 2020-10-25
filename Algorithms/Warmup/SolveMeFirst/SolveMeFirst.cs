/*
  Question : https://www.hackerrank.com/challenges/solve-me-first/problem

  int solveMeFirst(int a, int b);

    where,

    a is the first integer input.
    b is the second integer input
    Return values

    sum of the above two integers
    Sample Input

    a = 2
    b = 3
    Sample Output

        5
*/

using System;

namespace HackerRank.Algorithms.Warmup.SolveMeFirst
{
    class SolveMeFirst
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Please insert 2 number :");
            var num1 = int.Parse(Console.ReadLine());
            var num2 = int.Parse(Console.ReadLine());
            Console.WriteLine(num1 + num2);
        }
    }
}
