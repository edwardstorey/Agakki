import csv

beatList = []
mapList = []
csvReader = None
with open("AttackOnTitan-Beats.txt",'r') as f:
    beatList = f.readlines()
csvReader = csv.DictReader(open("AttackOnTitan-Beatmap-final.csv",'r'))

with open("AttackOnTitan-Beatmap.csv",'w') as f:
    
    f.write("time,left,right,both,comments\n")

    for row in csvReader:
        beatNumber = float(row['beatNo'])
        time = float(beatList[int(beatNumber)])

        if (beatNumber != int(beatNumber)):
            # Assumes there is always an integer beat after current beat value
            time += (float(beatList[int(beatNumber) + 1]) - float(beatList[int(beatNumber)])) * (beatNumber - float(int(beatNumber)))

        # outputs new line to f
        f.write(str(time))
        for key in row.keys():
            if (key != 'beatNo'):
                f.write(',' + str(row[key]))
        f.write('\n')

