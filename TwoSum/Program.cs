﻿using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("How many numbers?");
        int max = Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[max];

        for (int x = 0; x < arr.Length; x++)
        {
            Console.WriteLine("Input a number");
            int num = Convert.ToInt32(Console.ReadLine());
            arr[x] = num;
        }
        bool TwoSum = false;
        Console.WriteLine("Input the target sum:");
        int target = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < arr.Length - 1; i++)
        {
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[i] + arr[j] == target)
                {
                    TwoSum = true;
                    Console.WriteLine($"array[{i},{j}]");
                    Console.WriteLine($"{arr[i]} + {arr[j]} = {target}");
                    break;
                }

            }
            if (TwoSum == true)
            {
                break;
            }
        }
    }
}
