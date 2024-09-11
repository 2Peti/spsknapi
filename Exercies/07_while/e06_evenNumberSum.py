lower = int(input("Zadajte dolný limit: "))
upper = int(input("Zadajte horný limit: "))
total = 0
for i in range(lower, upper + 1):
    if i % 2 == 0:
        total += i
print(total)

lower = int(input("Zadajte dolný limit: "))
upper = int(input("Zadajte horný limit: "))
total = 0
i = lower
while i <= upper:
    if i % 2 == 0:
        total += i
    i += 1
print(total)
