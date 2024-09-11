rok = int(input("Zadajte rok: "))

if (rok % 4 == 0 and rok % 100 != 0) or (rok % 400 == 0):
    print(f"Rok {rok} je prestupný.")
else:
    print(f"Rok {rok} nie je prestupný.")