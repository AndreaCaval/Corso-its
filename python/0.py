
import statistics

lista = []

for x in range (0,5):
    print("Inserisci un numero: ")
    lista.append(int(input())) 


print(statistics.mean(lista))