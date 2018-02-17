package com.nity6000.calculator;

import java.util.InputMismatchException;
import java.util.Scanner;

public class Main {

	public static void main(String[] args) {
		
		int firstNumber;
		int secondNumber;
		String operation;
		
		Scanner scanner = new Scanner(System.in);
		
		System.out.println("Enter your first number");
		try {
			firstNumber =  scanner.nextInt();
		} catch (InputMismatchException e) {
			System.out.println("Thats not a number, so we're going to make it 0");
			firstNumber = 0;
			scanner.next();
		}	
		System.out.println("Enter your second number");
		try {
			secondNumber =  scanner.nextInt();
		} catch (InputMismatchException e) {
			System.out.println("Thats not a number, so we're going to make it 0");
			secondNumber = 0;
			scanner.next();
		}
		System.out.println("Enter an operation");
		operation = scanner.next().substring(0, 1);
		switch (operation) {
		case "+":
			System.out.println(firstNumber + secondNumber);
			break;
		case "-":
			System.out.println(firstNumber - secondNumber);
			break;
		case "*":
			System.out.println(firstNumber * secondNumber);
			break;
		case "/":
			try {
				System.out.println(firstNumber / secondNumber);
			} catch (ArithmeticException e) {
				System.out.println("You can't divide by zero");
			}
			break;
		default:
			System.out.println("Invalid Operation, use either +, -, *, or /");
		}
		scanner.close();
	}
}
