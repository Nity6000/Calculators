#include <iostream>
using namespace std;

int main()
{
    float firstNumber;
    float secondNumber;

    char operation;

    cout << "Enter your first number" << endl;
    cin >> firstNumber;
    if (cin.fail())
    {
        firstNumber = 0;
        cout << "Thats not a number, so we're going to make it 0" << endl;
        std::cin.clear();
        std::cin.ignore(256,'\n');
    }

    cout << "Enter your second number" << endl;
    cin >> secondNumber;
    if (cin.fail())
    {
        secondNumber = 0;
        cout << "Thats not a number, so we're going to make it 0" << endl;
        std::cin.clear();
        std::cin.ignore(256,'\n');
    }

    cout << "Enter the operation you want to do" << endl;
    cin >> operation;

    switch (operation)
    {
        case '+':
            cout << firstNumber + secondNumber << endl;
            break;
        case '-':
            cout << firstNumber - secondNumber << endl;
            break;
        case '*':
            cout << firstNumber * secondNumber << endl;
            break;
        case '/':
            if (secondNumber != 0)
            {
               cout << firstNumber / secondNumber << endl;
            }
            else
            {
                cout << "You can't divide by zero" << endl;
            }
            break;
        default:
            cout << "Invalid Operation, use either +, -, *, or /" << endl;
            break;
    }
}
