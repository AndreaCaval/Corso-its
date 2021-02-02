'''
INPUT: sequenza di caratteri
OUTPUT: massimo e minimo inseriti
'''

n = 1
lista = []

while n != 0:

    try:
        n = int(input("Inserisci un numero: "))
        if(n != 0):
            lista.append(n)
    except:
        print("Errore di inserimento")

if(len(lista) != 0):
    print("Lista= " + str(lista))
    print("Minimo: " + str(min(lista)))
    print("Massimo: " + str(max(lista)))
else:
    print("La lista è vuota")
