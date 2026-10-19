using System;
using System.Collections.Generic;
using NUnit.Framework.Interfaces;
using Unity.Mathematics;
using Unity.VisualScripting;

namespace Assignment
{
    public class StudentSolution
    {
        #region Lecture

        public int LCT01_RecursiveFactorial(int n)
        {
            return Factorial(n);
        }

        private int Factorial(int n)
        {
            // base case
            if (n <= 1)
            {
                return 1;
            }
            // recursive case
            return n * Factorial(n - 1);
        }

        public int LCT02_RecursiveFibonacci(int n)
        {
            return Fibonacci(n);
        }

        private int Fibonacci(int n)
        {
            // base case
            if (n <= 1)
            {
                return n;
            }
            // recursive case
            //fib(5) = fib(4) + fib(3)
            //fib(4) = fib(3) + fib(2)
            //fib(3) = fib(2) + fib(1)
            //fib(2) = fib(1) + fib(0)
            //fib(n) = fib(n-1) + fib(n-2)
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }

        public int LCT03_RecursiveSumOfOneToN(int n)
        {
            //n = 5 =>5+4+3+2+1
            //      => 5 + sum(4)
            return SumOfOneToN(n);
        }

        private int SumOfOneToN(int n)
        {
            // base case
            if (n <= 1)
            {
                return n;
            }

            // recursive case

            return n + SumOfOneToN(n - 1);
        }

        public int LCT04_RecursiveSumOfNumbers(int[] numbers)
        {
            return SumOfNumbers(numbers, 0);
        }

        private int SumOfNumbers(int[] numbers, int index)
        {
            // ex. numbers = [1,2,3,4,5]
            //sum = numbers[0] + numbers[1] + numbers[2] + numbers[3] + numbers[4] 
            // sum = numbers[n-1] + numbers[n-2] + numbers[n-3] ...numbers[0] 
            //sum = numbers[n-1] + sum(n-2)
            // base case
            if (index >= numbers.Length)
            {
                return 0;
            }
            // recursive case

            return numbers[index] + SumOfNumbers(numbers, index + 1);
        }

        #endregion

        #region Assignment

        public int ASN01_RecursivePower(int baseNum, int exponent)
        {
            return Power(baseNum, exponent);
        }

        private int Power(int baseNum, int exponent)
        {
            if (exponent == 0)
            {
                return 1;
            }
            return baseNum * Power(baseNum, exponent - 1);
        }

        public bool ASN02_IsPalindrome(string str)
        {
            return IsPalindrome(str, 0, str.Length - 1);
        }

        private bool IsPalindrome(string str, int start, int end)
        {
            if (start > end)
            {
                return true;
            }
            if (str[start] != str[end])
            {
                return false;
            }
            return IsPalindrome(str, start + 1, end - 1);
        }

        public int ASN03_RecursiveGCD(int a, int b)
        {
            return GCD(a, b);
        }

        private int GCD(int a, int b)
        {
            if (b == 0)
            {
                return a;
            }
            return GCD(b, a % b);
        }

        public int ASN04_RecursiveBinarySearch(int[] arr, int target)
        {
            return BinarySearch(arr, target, 0, arr.Length - 1);
        }

        private int BinarySearch(int[] arr, int target, int low, int high)
        {
            if (low > high)
            {
                return -1;
            }
            int mid = low + (high - low) / 2;
            if (arr[mid] == target)
            {
                return mid;
            }
            if (arr[mid] > target)
            {
                return BinarySearch(arr, target, low, mid - 1);
            }
            if (arr[mid] < target)
            {
                return BinarySearch(arr, target, mid + 1, high);
            }

            return -1;
        }

        #endregion

    }
}