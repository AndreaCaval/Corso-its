
d = 6
l = [x for x in range(1,d+1)]

w = d

for x in l:
    s = " "*x
    for y in range (0, w):
        s += str(l[x-1]) + " "
    w = w - 1
    print(s)

w = d
for x in l:
    s = " "*(len(l)-x+1)
    for y in range (0, x):
        s += str(l[x-1]) + " "
    w = w - 1
    print(s)