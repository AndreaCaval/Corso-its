import statistics

lista = []

n = int(input("Inserisci un numero: "))

while n != 0:
    lista.append(n)
    n = int(input("Inserisci un numero: "))
    
print("Media = ", statistics.mean(lista))
