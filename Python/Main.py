FirstNumber = None
SecondNumber = None
Operation = None
StayOpen = None

try:
    FirstNumber = int(input("Enter your first number\n"))
except ValueError:
    print("That's not a whole number")
try:
    SecondNumber = int(input("Enter your second number\n"))
except:
    print("That's not a whole number")
Operation = input("Enter an operation\n")

if Operation == '+':
    print(FirstNumber + SecondNumber)
elif Operation == '-':
    print(FirstNumber - SecondNumber)
elif Operation == '*':
    print(FirstNumber * SecondNumber)
elif Operation == '/':
    if SecondNumber != 0:
        print(FirstNumber / SecondNumber)
    else:
        print("Can't divide by zero")
else:
    print("Invalid Operation, use either +, -, *, or /")

StayOpen = input()
