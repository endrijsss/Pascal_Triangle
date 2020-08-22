# Takes input from the user
n = int(input("enter the number of rows:"))

# Stores values of the pascal triangle in the list
list1 = []
for i in range(n):
    temp_list=[]
    for j in range(i+1):
        if j==0 or j==i:
            temp_list.append(1)
        else:
            temp_list.append(list1[i-1][j-1] + list1[i-1][j])
    list1.append(temp_list)

# Prints present values of the nested list in the required shape
for i in range(n):
    for j in range(n-i-1):
        print(format(" ","<2"), end="")
    for j in range(i+1):
        print(format(list1[i][j],"<3"),end=" ")
    print()
