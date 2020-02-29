import csv

beatList = []
mapList = []
csvReader = None
with open("YMCA-Beats.txt",'r') as f:
    beatList = f.readlines()
beatList.insert(0, 0) # insert dummy value in front to make beatList[i] equal to time value at beat i
csvReader = csv.DictReader(open("YMCA-Beatmap-final.csv",'r'))

with open("YMCA-Beatmap-test.csv",'w') as f:
    
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

