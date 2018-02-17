using System;

namespace Calculator {

    class MainClass {

        public static void Main(string[] args) {

            int FirstNumber;
            int SecondNumber;

            Console.WriteLine("Enter your first number");
            try {
                FirstNumber = Convert.ToInt32(Console.ReadLine());
            } catch (FormatException) {
                FirstNumber = 0;
                Console.WriteLine("Thats not a number, so we're going to make it 0");
            }
            Console.WriteLine("Enter your second number");
            try {
                SecondNumber = Convert.ToInt32(Console.ReadLine());
            } catch (FormatException) {
                SecondNumber = 0;
                Console.WriteLine("Thats not a number, so we're going to make it 0");
            }
            Console.WriteLine("Enter an operation");
            char Operation;
            Operation = Convert.ToChar(Console.ReadLine().Substring(0, 1));
            switch (Operation) {
                case '+':
                    Console.WriteLine(FirstNumber + SecondNumber);
                    break;
                case '-':
                    Console.WriteLine(FirstNumber - SecondNumber);
                    break;
                case '*':
                    Console.WriteLine(FirstNumber * SecondNumber);
                    break;
                case '/':
                    try {
                        Console.WriteLine(FirstNumber / SecondNumber);
                    } catch (DivideByZeroException) {
                        Console.WriteLine("You can't divide by zero");
                    }
                    break;
                default:
                    Console.WriteLine("Invalid Operation, use either +, -, *, or /");
                    break;
            }
            Console.ReadKey();
        }
    }
}
