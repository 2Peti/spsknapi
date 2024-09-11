start = int(input("Zadajte počiatočné číslo: "))
product = 1
for i in range(start, start + 7):
    product *= i
print(product)


start = int(input("Zadajte počiatočné číslo: "))
product = 1
i = start
while i < start + 7:
    product *= i
    i += 1
print(product)
