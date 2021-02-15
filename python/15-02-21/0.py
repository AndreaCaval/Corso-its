import csv
csvFile = open('C:/Users/Andrea/Documents/dev/Corso-its/python/15-02-21/data.csv', 'r')
buffer = csv.reader(csvFile, delimiter=',')    
for row in buffer:	
	print('{0} - {1} - {2} - {3}'.format(row[0], row[1], row[2], row[3]))
csvFile.close()
