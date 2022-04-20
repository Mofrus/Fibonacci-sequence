using System;

namespace Fibonacci_sequence
{
    internal class Program
    {
        public void Init(string[] args)
        {
            UserInput input = new UserInput();
            input.InputManager();
            
            Console.ReadKey();
        }
        public static void Main(string[] args)
        {
            new Program().Init(args);
        }
    }
}