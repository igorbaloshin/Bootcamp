from random import randint

x = randint(0, 100)
# метод последовательного перебора
count_perebor = 0
for i in range(0, 101):
    count_perebor += 1
    if i == x:
        print("Число найдено")
        break

print("Загадонное чило было", x, "и потребовалось", count_perebor, "итераций")

# метод случайного отгадывания
count_random = 1

y = randint(0, 100)
while x != y:
    y = randint(0, 100)
    count_random += 1

print("Загадонное чило было", x, "и потребовалось", count_random, "итераций")

# алгоритм бинарного поиска


count_bin = 1
print('Давай начнем игру - угадай число от 0 до 100')
left = 0
right = 100
mid = (right + left)//2
while x != mid:
    print(mid)
    if x < mid:
        right = mid - 1

    else:
        left = mid + 1
    mid = (right + left)//2

    count_bin += 1

print("Загадонное чило было", x, "и потребовалось", count_bin, "итераций")

# count_bin = 1  # ??????????????? не работает
# left = 0
# right = 100


# def FindPosition(x, left, right):

#     if x < mid:

#         mid = (right + left)//2
#         if x == mid:
            
#             return mid
#         else:
#             print(mid)
#             return FindPosition(x, left, mid - 1)
#     else:

#         mid = (right + left)//2
#         if x == mid:
            
#             return mid
#         else:
#             print(mid)
#             return FindPosition(x, mid + 1, right)



