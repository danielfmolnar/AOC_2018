with open("input_01.txt") as f:
    content = f.readlines()

content = [int(x.strip()) for x in content]

len(content)

sumvar = 0
mylist = [sumvar]
for i in range(0,len(content)):
    sumvar = sumvar + content[i]
    if sumvar in mylist:
        print(sumvar)
    mylist = mylist + [sumvar]

len(mylist)

import pandas as pd

df = pd.DataFrame(mylist)

df.columns = ["vals"]

for i in range(0,len(mylist)):
    for j in range(i+1,len(mylist)):
        if mylist[i]==mylist[j]:
            print(mylist[i])

len(mylist)
df.vals.value_counts()

content
mylist
