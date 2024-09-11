from sympy import isprime

print("""This program will find the prime numbers for you. You can choose:
1- just the prime numbers
2- numbers that are not prime numbers
3- both
q- quit""")

while True:
    choice = input("- ")
    if choice == 'q':
        break

    if choice in ['1', '2', '3']:
        upper = int(input("Give the upper border: "))

        if choice == '1':
            for num in range(2, upper + 1):
                if isprime(num):
                    print(f"{num}, is a prime number")
        elif choice == '2':
            for num in range(2, upper + 1):
                if not isprime(num):
                    for i in range(2, num):
                        if num % i == 0:
                            print(f"{num} equals {i}*{num // i}")
                            break
        elif choice == '3':
            for num in range(2, upper + 1):
                if isprime(num):
                    print(f"{num}, is a prime number")
                else:
                    for i in range(2, num):
                        if num % i == 0:
                            print(f"{num} equals {i}*{num // i}")
                            break
    else:
        print("Invalid choice. Please enter 1, 2, 3, or q.")
