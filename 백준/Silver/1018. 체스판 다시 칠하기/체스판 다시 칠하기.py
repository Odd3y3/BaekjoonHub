n, m = map(int, input().split())

chess_board = []
for i in range(4):
    chess_board.append(list("WBWBWBWB"))
    chess_board.append(list("BWBWBWBW"))

input_board = []
for i in range(n):
    input_board.append(list(input()))

result = 64
for i in range(n-8+1):
    for j in range(m-8+1):
        count = 0
        for x in range(8):
            for y in range(8):
                if chess_board[x][y] != input_board[x+i][y+j]:
                    count += 1
        result = min(count, 64-count, result)

print(result)