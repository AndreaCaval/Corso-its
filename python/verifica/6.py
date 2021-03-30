import json

with open('x.json') as json_file:
    data = json.load(json_file)

elenco = []

for name in data["dvd"]:
    elenco.append(name["nome"])

print(sorted(elenco))
