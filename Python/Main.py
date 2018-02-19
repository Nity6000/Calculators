FirstNumber = None
SecondNumber = None
Operation = None
StayOpen = None

try:
    FirstNumber = float(input("Enter your first number\n"))
except ValueError:
    print("That's not a number, so we're going to make it 0")
    FirstNumber = 0
try:
    SecondNumber = float(input("Enter your second number\n"))
except ValueError:
    print("That's not a number, so we're going to make it 0")
    SecondNumber = 0
Operation = input("Enter an operation\n")

if Operation == '+':
    print(FirstNumber + SecondNumber)
elif Operation == '-':
    print(FirstNumber - SecondNumber)
elif Operation == '*':
    print(FirstNumber * SecondNumber)
elif Operation == '/':
    try:
        print(FirstNumber / SecondNumber)
    except ZeroDivisionError:
        print("Can't divide by zero")
else:
    print("Invalid Operation, use either +, -, *, or /")

StayOpen = input()
