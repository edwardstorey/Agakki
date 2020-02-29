def printNotes(start, end, number):
    spb = (end-start)/number
    for a in range(number):
        print(start+a*spb)