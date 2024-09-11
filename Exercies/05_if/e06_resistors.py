# Získanie odporov od používateľa
R1 = int(input("Zadajte hodnotu odporu R1: "))
R2 = int(input("Zadajte hodnotu odporu R2: "))

# Výpis výsledkov
print(f"Výsledný odpor pri sériovom zapojení je: {R1 + R2}")
print(f"Výsledný odpor pri paralelnom zapojení je: {(R1 * R2) / (R1 + R2)}")
