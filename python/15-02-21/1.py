import csv

testo = ""

csvFile = open('C:/Users/Andrea/Documents/dev/Corso-its/python/15-02-21/data.csv', 'r')
buffer = csv.reader(csvFile, delimiter=',')    
for row in buffer:	
    print('{0} - {1} - {2} - {3}'.format(row[0], row[1], row[2], row[3]))
    testo += row[0] + " - " + row[1] + " - " +  row[2] + " - " + row[3] + "\n"
	
csvFile.close()

print(testo)

fout = open("C:/Users/Andrea/Documents/dev/Corso-its/python/15-02-21/out.txt", "w")
fout.write(testo)
fout.close
