text = input("Zadajte text: ")

if text.islower():
    print("Text je malými písmenami.")
elif text.isupper():
    print("Text je veľkými písmenami.")
elif text.isnumeric():
    print("Text je číslo.")
else:
    print("Text nie je ani malými písmenami, veľkými písmenami, ani číslo.")