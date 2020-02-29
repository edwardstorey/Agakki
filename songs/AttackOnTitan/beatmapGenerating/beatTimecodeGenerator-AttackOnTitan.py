# To be cleaned up

# Between partialBeatTimecodeList[i] and partialBeatTimecodeList[i + 1],
# there are durationList[i] beats
partialBeatTimecodeList = [1.017, 3.740, 14.389, 15.670, 36.931, 47.591, 67.492, 87.921]
durationList = [8, 32, 4, 64, 32, 60, 62]
secondsPerBeatList = []
beatTimecodeList = []
for i in range(len(durationList)):
    secondsPerBeatList.append((partialBeatTimecodeList[i + 1] - partialBeatTimecodeList[i]) / durationList[i])
    print(str(partialBeatTimecodeList[i + 1]) + ' - ' + str(partialBeatTimecodeList[i]) + '\n')
    for j in range(durationList[i]):
        beatTimecodeList.append(partialBeatTimecodeList[i] + (secondsPerBeatList[i] * j))
beatTimecodeList.append(partialBeatTimecodeList[-1])

print(secondsPerBeatList)

with open('AttackOnTitan-Beats.txt', 'w') as output:
    for timecode in beatTimecodeList:
        output.write(str(timecode) + '\n')