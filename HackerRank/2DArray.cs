using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;


namespace HackerRank
{
    class _2DArray
    {
        // Complete the hourglassSum function below.
        static int hourglassSum(int[][] arr)
        {
            Console.Write(arr);

            return 0;

        }

        static void Main(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

           

            //for (int i = 0; i < 6; i++)
            //{
            //    arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            //}

            int[,] arr = new int[,] { { 1, 1, 1, 0, 0, 0 }, { 0, 1, 0, 0, 0, 0 }, { 1, 1, 1, 0, 0, 0 }, { 0, 0, 2, 4, 4, 0 }, { 0, 0, 0, 2, 0, 0 }, { 0, 0, 1, 2, 4, 0 } };
            
                   

            int result = hourglassSum(arr);

           // textWriter.WriteLine(result);
           // textWriter.Flush();
           // textWriter.Close();
        }

    }
}




//Given a  2D Array, :

//1 1 1 0 0 0
//0 1 0 0 0 0
//1 1 1 0 0 0
//0 0 0 0 0 0
//0 0 0 0 0 0
//0 0 0 0 0 0
//We define an hourglass in  to be a subset of values with indices falling in this pattern in 's graphical representation:

//a b c
//  d
//e f g
//There are hourglasses in , and an hourglass sum is the sum of an hourglass' values. Calculate the hourglass sum for every hourglass in , then print the maximum hourglass sum.

//For example, given the 2D array:

//-9 -9 -9  1 1 1 
// 0 -9  0  4 3 2
//-9 -9 -9  1 2 3
// 0  0  8  6 6 0
// 0  0  0 -2 0 0
// 0  0  1  2 4 0
//We calculate the following  hourglass values:

//-63, -34, -9, 12,
//-10, 0, 28, 23,
//-27, -11, -2, 10,
//9, 17, 25, 18
//Our highest hourglass value is  from the hourglass:

//0 4 3
//  1
//8 6 6