/*
    
Question : https://www.hackerrank.com/challenges/simple-array-sum/problem 

Given an array of integers, find the sum of its elements.
For example, if the array , , so return .

Function Description

Complete the simpleArraySum function in the editor below. It must return the sum of the array elements as an integer.

simpleArraySum has the following parameter(s):

ar: an array of integers
Input Format

The first line contains an integer, , denoting the size of the array.
The second line contains  space-separated integers representing the array's elements.

Constraints


Output Format

Print the sum of the array's elements as a single integer.

Sample Input

6
1 2 3 4 10 11
Sample Output

31
Explanation


*/

using System;
using System.Linq;

namespace HackerRank.Algorithms.Warmup.SimpleArraySum
{
    class SimpleArraySum
    {
        static void Main(string[] args)
        {
            Console.ReadLine();
            var temp_arr = Console.ReadLine().Split(' ');
            var arr = Array.ConvertAll(temp_arr, int.Parse); //To be sure that all elements of Array is Integer
            Console.WriteLine(arr.Sum()); //This Sum method is O(n) time complexity ( LINQ )
        }
    }
}
