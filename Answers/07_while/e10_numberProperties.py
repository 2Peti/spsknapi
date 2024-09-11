div_10 = div_3 = over_50 = under_50 = 0
total_sum = count = 0

while True:
    inp = input("Enter a number (or `q` to quit): ")
    if inp == 'q':
        break
    
    try:
        num = int(inp)
        total_sum += num
        count += 1
        
        if num % 10 == 0:
            div_10 += 1
        if num % 3 == 0:
            div_3 += 1
        if num > 50:
            over_50 += 1
        elif num < 50:
            under_50 += 1
    except ValueError:
        print("Please enter a valid integer or `q` to quit.")

avg = total_sum / count if count > 0 else 0

print(f"Numbers divisible by 10: {div_10}")
print(f"Numbers divisible by 3: {div_3}")
print(f"Numbers greater than 50: {over_50}")
print(f"Numbers less than 50: {under_50}")
print(f"Average: {avg:.2f}")
