t = int(input())

for i in range(t):
    x1,y1,r1,x2,y2,r2 = map(int, input().split())
    dis = (abs(x1-x2)**2 + abs(y1-y2)**2)**(1/2)
    if dis == 0 and r1 == r2:
        print(-1)
    elif dis > r1+r2 or dis < abs(r1-r2):
        print(0)
    elif dis == r1+r2 or dis == abs(r1-r2):
        print(1)
    else:
        print(2)