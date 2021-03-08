import sys 

dizionario = {}

with open("C:/Users/Andrea/Documents/dev/Corso-its/python/08-03-21/file.txt") as fileHandler:
    lines = fileHandler.readlines()

for line in lines:

    line = line.replace('\n', '')
    parole = line.split(' ')
    
    for parola in parole:
        if(parola not in dizionario):
            dizionario[parola] = 1
        else :
            dizionario[parola] += 1     
        
print(dizionario)


