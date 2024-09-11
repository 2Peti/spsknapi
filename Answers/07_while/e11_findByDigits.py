max_1_digit = -1
max_2_digit = -1
max_3_digit = -1

num_count = int(input("Enter the number of values you want to input: "))

for _ in range(num_count):
    try:
        num = int(input("Enter a number: "))
        if 0 <= num <= 9:
            max_1_digit = max(max_1_digit, num)
        elif 10 <= num <= 99:
            max_2_digit = max(max_2_digit, num)
        elif 100 <= num <= 999:
            max_3_digit = max(max_3_digit, num)
    except ValueError:
        print("Please enter a valid integer.")

print(f"Largest 1-digit number: {max_1_digit if max_1_digit != -1 else 'None'}")
print(f"Largest 2-digit number: {max_2_digit if max_2_digit != -1 else 'None'}")
print(f"Largest 3-digit number: {max_3_digit if max_3_digit != -1 else 'None'}")
