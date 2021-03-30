minori = -1
maggiori = 0
uguali = 0

n1 = int(input("Inserisci un numero da confrontare: "))
n2 = 1

while n2 != 0:
    n2 = int(input("Inserisci un numero: "))
    if(n1 == n2):
        uguali+=1
    elif(n1 > n2):
        minori+=1
    elif(n1 < n2):
        maggiori+=1
    
    
print("Numeri minori:" + str(minori))
print("Numeri maggori:" + str(maggiori))
print("Numeri uguali:" + str(uguali))