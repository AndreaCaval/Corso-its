vocali = ['a', 'e', 'i', 'o', 'u']
vocali_stringa = ""

stringa = input("Inserisci una stringa: ")
for x in stringa:
  if(x in vocali):
      vocali_stringa += x + ", "
    
print("Vocali nella stringa: " + vocali_stringa)