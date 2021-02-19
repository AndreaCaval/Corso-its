fRead = open("C:/Users/Andrea/Documents/dev/Corso-its/python/19-02-21/1read.txt")
fWrite = open("C:/Users/Andrea/Documents/dev/Corso-its/python/19-02-21/1write.txt", "w")
righe = fRead.readlines()
testoNew = []   #elenco vocali
for riga in righe:
    for carattere in riga:
        if carattere.lower() not in {"a","e","i","o","u"}:
            testoNew.append(carattere)
    
fWrite.write("".join(testoNew))
fRead.close()
fWrite.close()