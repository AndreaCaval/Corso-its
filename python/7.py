l = [1,2,3,4,5,6]

w = 6

for x in l:
    s = " "*x
    for y in range (0, w):
        s += str(l[x-1]) + " "
    w = w - 1
    print(s)

w = 6
for x in l:
    s = " "*(len(l)-x+1)
    for y in range (0, x):
        s += str(l[x-1]) + " "
    w = w - 1
    print(s)