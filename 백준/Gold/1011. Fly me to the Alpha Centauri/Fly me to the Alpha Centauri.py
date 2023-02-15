import sys
num = int(input())

for i in range(num):
    x,y = map(int, sys.stdin.readline().split())
    dis = y - x
    count = 0
    sum = 0
    while dis > sum :
        count += 1
        sum = sum + (count-1)//2 + 1
    print(count)