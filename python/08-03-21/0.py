#import sys 

testo2 = ""

parola = input("Inserisci una stringa: ")

with open("C:/Users/Andrea/Documents/dev/Corso-its/python/08-03-21/file.txt") as fileHandler:
    lines = fileHandler.readlines()

for line in lines:
    if("\n" in line):     
        if(line != "\n"):
            testo2 += line.replace("\n"," "+ parola + "\n")
        else:
            testo2 += line.replace("\n",parola + "\n")        
    else:
        if(line != ""):
            testo2 += line + " " + parola
        else:
            testo2 += parola
    
f = open("testo2.txt", "w")
f.write(testo2)
f.close()


