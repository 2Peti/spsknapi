a = int(input("Give a: "))
b = int(input("Give b: "))
c = int(input("Give c: "))

if a >= b and a >= c:
    print("a is bigger than b and c")
elif b >= a and b >= c:
    print("b is bigger than a and c")
else:
    print("c is bigger than a and b")