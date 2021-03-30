import random

count_testa = 0

for x in range(0,100):
    lancio = random.randint(0,1)
    if(lancio == 0):
        count_testa += 1

print("Testa è uscita: %d volte" %count_testa) 
