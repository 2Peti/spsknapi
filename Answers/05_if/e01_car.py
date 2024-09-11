areas = [["residential area",50],["outside of residential area",90],["highway",130]]

print("You are driving in")
for i, limit in enumerate(areas, 1):
    print(f"{i}- {limit[0]}")

area = int(input())
speed = int(input("Give me your speed in km/h: "))

limit = areas[area - 1][1]

if speed < limit - 10:
    print("you're driving too slow")
elif speed <= limit:
    print("you're driving optimal")
elif speed <= limit + 20:
    print("you're driving too fast")
else:
    print("you will get a ticket")