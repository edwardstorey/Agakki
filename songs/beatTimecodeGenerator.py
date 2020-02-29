# To be cleaned up

# Between partialBeatTimecodeList[i] and partialBeatTimecodeList[i + 1],
# there are durationList[i] beats
partialBeatTimecodeList = [1.212, 5.034, 8.848, # intro
    12.592, 16.406, 20.162, 23.899, # verse 1
    27.603, 31.379, 35.220, 38.991,
    42.674, #bridge
    46.417, 50.200, 53.959, 57,727, # chorus
    61.459, 65.215, 68.990, 72.737,
    76.440]
durationList = [8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8] # duration list has one less item than beatTimecodeList
secondsPerBeatList = []
beatTimecodeList = []
for i in range(len(durationList)):
    secondsPerBeatList.append((partialBeatTimecodeList[i + 1] - partialBeatTimecodeList[i]) / durationList[i])
    for j in range(durationList[i]):
        beatTimecodeList.append(partialBeatTimecodeList[i] + (secondsPerBeatList[i] * j))
beatTimecodeList.append(partialBeatTimecodeList[-1])

print(secondsPerBeatList)

with open('YMCABeats.txt', 'w') as output:
    for timecode in beatTimecodeList:
        output.write(str(timecode) + '\n')