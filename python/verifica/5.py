import csv

def check(cognome):
    if cognome in open('dati.csv').read():
        getMail(cognome)
    else:
        print("Cognome non presente")

def getMail(cognome):
    with open('dati.csv', 'r') as file:
        reader = csv.reader(file)
        for row in reader:
            if cognome in row:
                print("Email: "+ row[2])


cognome = input("Inserisci un cognome: ")
check(cognome)