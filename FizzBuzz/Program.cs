﻿using System;

public class FizzBuzz
{
    public static string FizzBuzzMethod(int num)
    {
        if (num % 3 == 0 && num % 5 == 0)
        {
            return "FizzBuzz";
        }
        else if (num % 3 == 0)
        {
            return "Fizz";
        }
        else if (num % 5 == 0)
        {
            return "Buzz";
        }
        else
        {
            return num.ToString();
        }
    }

    static void Main()
    {
        int testNumber = 15;
        Console.WriteLine(FizzBuzzMethod(testNumber));
    }
}