n = int(input())
g = input()
s = [input() for i in range(n)]

for k in s:
    if k.find(g) > -1:
        print(k)
        k = 'ok'
        
if k != 'ok':
    print('None')
