using System;
using System.Runtime.InteropServices;

namespace lab4_2
{
    static class Program
    {
        [DllImport("Dll.dll", CallingConvention = CallingConvention.Cdecl)]
        static extern int Add(int a, int b);

        [DllImport("Dll.dll", CallingConvention = CallingConvention.Cdecl)]
        static extern int Subtract(int a, int b);

        [DllImport("Dll.dll", CallingConvention = CallingConvention.Cdecl)]
        static extern int Multiply(int a, int b);

        [DllImport("Dll.dll", CallingConvention = CallingConvention.Cdecl)]
        static extern int Division(int a, int b);

        [DllImport("Dll.dll", CallingConvention = CallingConvention.Cdecl)]
        static extern int RemainderOfTheDivision(int a, int b);

        static int CheckInt()
        {
            int a;
            while (!int.TryParse(Console.ReadLine(), out a))
            {
                Console.Write("Invalid data, please try again: ");
            }
            return a;
        }

        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("First number: ");
                int num1 = CheckInt();
                Console.Write("Second number: ");
                int num2 = CheckInt();

                Console.WriteLine($"{num1} + {num2} = {Add(num1, num2)}");
                Console.WriteLine($"{num1} - {num2} = {Subtract(num1, num2)}");
                Console.WriteLine($"{num1} * {num2} = {Multiply(num1, num2)}");
                Console.WriteLine($"{num1} / {num2} = {Division(num1, num2)}");
                Console.WriteLine($"{num1} % {num2} = {RemainderOfTheDivision(num1, num2)}");
            }
        }
    }
}