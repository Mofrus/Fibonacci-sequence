﻿using System;

namespace Fibonacci_sequence
{
    public class UserInput
    {
        private static int arrayLenght;
        public void InputManager()
        {
            Fibonacci_S sequence = new Fibonacci_S();
            Console.Write($"Insert the amount of numbers you want to write out: ");
            try
            {
                arrayLenght = int.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            sequence.SequenceOutput(arrayLenght);
        }
    }
}