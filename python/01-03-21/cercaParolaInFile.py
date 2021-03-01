import sys 

filename = ""
word = ""
c = 0
occorrenze = 0

for x in sys.argv:
    if(c == 0):
        c=1
    elif(c == 1):
        filename = x
        c=2
    elif(c == 2):
        word = x
        c=3

if(filename == "" or word == ""):
    filename = input("inserisci il nome del file: ")
    word = input("insersci la parola da cercare: ")

lines = []
with open("C:/Users/Andrea/Documents/dev/Corso-its/python/01-03-21/"+filename+".txt") as fileHandler:
    lines = fileHandler.readlines()

for line in lines:
    occorrenze += line.count(word)

print(occorrenze)
