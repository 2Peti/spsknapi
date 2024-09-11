even = odd = over_10 = under_10 = 0

while True:
    inp = input("Give me a number or `q` to quit: ")
    if inp == 'q':
        break

    if inp.isdigit():
        num = int(inp)
        if 5 <= num <= 25:
            even += num % 2 == 0
            odd += num % 2 != 0
            over_10 += num > 10
            under_10 += num < 10
        else:
            print("The value has to be between 5 and 25.")
    else:
        print("Please enter a valid integer or `q` to quit.")

print(f"There were:\n{even} even numbers\n{odd} odd numbers\n{under_10} numbers smaller than 10\n{over_10} numbers bigger than 10")
