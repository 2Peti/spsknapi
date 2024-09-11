n = int(input("Give odd number between <5,11>: "))

if n % 2 == 1 and 5 <= n <= 11:
    for i in range(n):
        row = '*' * i + 'I' + '*' * (n - i - 1)
        print(row)
else:
    print("not good number")
