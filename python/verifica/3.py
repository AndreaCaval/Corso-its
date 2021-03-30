vocali = ['a', 'e', 'i', 'o', 'u']
vocali_stringa = ""

stringa = input("Inserisci una stringa: ")
if(stringa != "end"):
    for x in stringa:
        if(x in vocali):
            vocali_stringa += x + ", "
    vocali_stringa += "\n"


while stringa != "end":
    stringa = input("Inserisci una stringa: ")
    if(stringa != "end"):
        for x in stringa:
            if(x in vocali):
                vocali_stringa += x + ", "
        vocali_stringa += "\n"
    
print("Vocali per ogni stringa: \n" + vocali_stringa)