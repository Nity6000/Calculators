using System;

namespace Calculator {

    class MainClass {

        public static void Main(string[] args) {

            float FirstNumber;
            float SecondNumber;

            Console.WriteLine("Enter your first number");
            try {
                FirstNumber = Convert.ToSingle(Console.ReadLine());
            } catch (FormatException) {
                FirstNumber = 0;
                Console.WriteLine("Thats not a number, so we're going to make it 0");
            }
            Console.WriteLine("Enter your second number");
            try {
                SecondNumber = Convert.ToSingle(Console.ReadLine());
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
                    if (SecondNumber == 0) {
                        try {
                            Console.WriteLine((int)FirstNumber / (int)SecondNumber);
                        } catch (DivideByZeroException) {
                            Console.WriteLine("You can't divide by zero");
                        }
                    } else {
                        Console.WriteLine(FirstNumber / SecondNumber);
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
