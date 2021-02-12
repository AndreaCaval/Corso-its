with open ("C:/Users/Andrea/Documents/dev/Corso-its/python/12-02-21/fileTesto.txt") as testo:
    righe = testo.readlines()
parole=[]
for riga in righe:
    if riga =='\n':
        righe.remove(riga)
      
for riga in righe:
    for parola in riga.split(" "):
        parole.append(parola)
        
print ("Il testo è formato da "+ str(len(parole)) + " parole")