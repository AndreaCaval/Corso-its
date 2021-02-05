l = [1,2,3,4,5]

for x in range (0,6):
    s = ""
    for y in range (0, x):
        s += str(l[y]) + " "
    print(s)