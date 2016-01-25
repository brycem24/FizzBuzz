print "How many terms should be displayed?"

maxTerms = int(raw_input())

for i in range(1, maxTerms + 1):
    if (i % 3 == 0 and i % 5 == 0):
        print "Fizz Buzz,",
    elif (i % 3 == 0):
        print "Fizz,",
    elif (i % 5 == 0):
        print "Buzz,",
    else:
        print i , ",",

