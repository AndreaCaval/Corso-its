testo2 = ""

parola = input("Inserisci una stringa: ")

with open("fileinput.txt") as fileHandler:
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
    
f = open("fileinput.txt", "w")
f.write(testo2)
f.close()