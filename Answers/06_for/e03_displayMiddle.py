num = int(input("Give odd number between <5,11>: "))
if 5 <= num <= 11 and num % 2 == 1:
    stars = "*" * ((num - 1) // 2)
    print(f"{stars}I{stars}\n"*num,end="")
else:
    print("not a good number")
