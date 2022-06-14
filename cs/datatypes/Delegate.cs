using System;

namespace datatypes
{
    partial class Program
    {
        // simple
        
        delegate void PrintSomeTextCallback(string text);

        static void PrintText(string text)
        {
            Console.WriteLine($"Type(delegate): text:{text}");
        }

        // add a little more complexity

        delegate double CalcCallback(double number1, double number2);

        static double Add(double number1, double number2) { return number1 + number2; }
        static double Subtract(double number1, double number2) { return number1 - number2; }
        static double Multiply(double number1, double number2) { return number1 * number2; }
        static double Divide(double number1, double number2) { return number1 / number2; }

        // multicasting

        delegate void DoSomethingCallback();

        static void Hello() { Console.WriteLine("Howdy!"); }
        static void Sup() { Console.WriteLine("Whatyadoing?"); }
        static void Goodbye() { Console.WriteLine("Fine, Buh Bye..."); }
    }
}