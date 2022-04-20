﻿using System;

namespace Fibonacci_sequence
{
    public class Fibonacci_S
    {
        public void SequenceOutput(int n)  
        {  
            int number = n - 1;
            int[] Fib = new int[number + 1];  
            Fib[0]= 0;  
            Fib[1]= 1;  
            for (int i = 2; i <= number;i++)  
            {  
                Fib[i] = Fib[i - 2] + Fib[i - 1];
            }
            
            for (int i = 0; i < Fib.Length; i++)
            {
                Console.Write($"{Fib[i]}, ");
            }
        }
    }
}