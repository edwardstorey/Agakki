# To be cleaned up

firstBeat = 1.212
duration = 75.229
beatsInDuration = 160
secondsPerBeat = duration / beatsInDuration

print(secondsPerBeat)

with open('YMCABeats.txt', 'w') as output:
	for i in range(160):
		output.write(str(firstBeat + secondsPerBeat * i) + '\n')