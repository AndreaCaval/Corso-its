lines = []
with open("C:/Users/Andrea/Documents/dev/Corso-its/python/12-02-21/fileTesto.txt") as fileHandler:
    lines = fileHandler.readlines()
vocals = ["a", "e", "i", "o", "u"]
vocalsString = ""

for line in lines:
    for c in line:
        for v in vocals:
            if c == v:
                vocalsString += c

with open("C:/Users/Andrea/Documents/dev/Corso-its/python/12-02-21/fileTesto.txt", "w") as fileHandler:
    fileHandler.write(vocalsString)