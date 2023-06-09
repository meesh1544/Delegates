﻿using System.Security.Cryptography.X509Certificates;

namespace Assignment8ex2
{
    public class MathSolutions
    {
        public double GetSum(double x, double y)
        {
            return x + y;
        }
        public double GetProduct(double a, double b)
        {
            return a * b;
        }
        public double GetDevide(double a, double b)
        {
            return a / b;
        }
        public void GetSmaller(double a, double b)
        {
            if (a < b)
                Console.WriteLine($" {a} is smaller than {b}");
            else if (b < a)
                Console.WriteLine($" {b} is smaller than {a}");
            else
                Console.WriteLine($" {b} is equal to {a}");
        }
        public delegate double calculate(double a, double b);
            
            

        static void Main(string[] args)
        {MathSolutions answer = new MathSolutions();
            Random r = new Random();
            double num1 = Math.Round(r.NextDouble() * 100);
            double num2 = Math.Round(r.NextDouble() * 100);
            
            Func<double, double, double> result = answer.GetProduct;
            Console.WriteLine(result(num1, num2));
            
            Action<double, double> Result = delegate (double num1, double num2) { Console.WriteLine($" {num1} + {num2} = {answer.GetSum(num1, num2)}"); };
            Result(100, 100);

            Action <double, double> Result2 = (double num1, double num2) => Console.WriteLine($" {num1} * {num2} = {answer.GetProduct(num1, num2)}"); 
            Result2(100, 100);

            Action<double, double> Result3 = answer.GetSmaller;
            Result3 (num1, num2);

            calculate result4 = new calculate(answer.GetSum);
            Console.WriteLine(result4(num1, num2));
        }
    }
}