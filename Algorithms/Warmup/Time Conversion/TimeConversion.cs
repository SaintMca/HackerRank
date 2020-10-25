/*
    Question : https://www.hackerrank.com/challenges/time-conversion/problem
  
*/

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;


class TimeConversion
{
    /*
     * Complete the timeConversion function below.
     */
    static void timeConversion(string time)
    {
        /* Exp : '12:01:00PM' 10 Chars */
        var amOrPm = time.Substring(8,2); // Last 2 Chars 
        var hour = time.Substring(0, 2); //12
        var minutesAndSecs = time.Substring(2, 6); //:01:00
        if (amOrPm == "AM" && hour == "12")
        {
            hour = "00";
        }
        else if (amOrPm == "PM")
        {
            var numericHour = int.Parse(hour);
            if (numericHour != 12)
            {
                hour = Convert.ToString(12 + numericHour);
            }
        }
        Console.WriteLine(hour + minutesAndSecs);
    }

    

    static void Main(String[] args)
    {        
        string time = Console.ReadLine();
        timeConversion(time);        
    }
}

