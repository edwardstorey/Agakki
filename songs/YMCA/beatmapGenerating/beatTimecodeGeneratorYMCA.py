# To be cleaned up

# Between partialBeatTimecodeList[i] and partialBeatTimecodeList[i + 1],
# there are durationList[i] beats
partialBeatTimecodeList = [1.212, 5.034, 8.848, # intro
    12.592, 16.406, 20.162, 23.899, # verse 1
    27.603, 31.379, 35.220, 38.991,
    42.674, #bridge
    46.417, 50.200, 53.959, 57.727, # chorus
    61.459, 65.215, 68.990, 72.737,
    76.440]
duration = 8
secondsPerBeatList = []
beatTimecodeList = []
for i in range(len(partialBeatTimecodeList) - 1):
    secondsPerBeatList.append((partialBeatTimecodeList[i + 1] - partialBeatTimecodeList[i]) / duration)
    print(str(partialBeatTimecodeList[i + 1]) + ' - ' + str(partialBeatTimecodeList[i]) + '\n')
    for j in range(duration):
        beatTimecodeList.append(partialBeatTimecodeList[i] + (secondsPerBeatList[i] * j))
beatTimecodeList.append(partialBeatTimecodeList[-1])

print(secondsPerBeatList)

with open('YMCABeats.txt', 'w') as output:
    for timecode in beatTimecodeList:
        output.write(str(timecode) + '\n')