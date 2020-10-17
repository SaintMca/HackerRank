/*
    Question : https://www.hackerrank.com/challenges/mini-max-sum/problem
    
    Given five positive integers, find the minimum and maximum values that can be calculated by summing exactly four of the five integers. 
    Then print the respective minimum and maximum values as a single line of two space-separated long integers.
*/

using static System.Console;

class MiniMaxSum
{
    static void Main(string[] args)
    {
        var integers = ReadLine().Split(',');
        long[] numbers = null;
        for (int i = 0; i < integers.Length; i++)
        {
            numbers[i] = long.Parse(integers[i]);
        }  //We could use LINQ for this       


        var sumOfAllNumbers = 0L;  //In question it says LongInt
        var minimum = long.MaxValue; //MaxValue ==> at 1st Compare, the value must be smaller than this.
        var maximum = 0L;

        for (int j = 0; j < 5; j++)
        {
            sumOfAllNumbers += numbers[j];
            if (numbers[j] < minimum)
                minimum = numbers[j];

            if (numbers[j] > maximum)
                maximum = numbers[j];

        }
        Console.WriteLine(string.Format("{0} {1}", sumOfAllNumbers - maximum, sumOfAllNumbers - minimum));
    }
}