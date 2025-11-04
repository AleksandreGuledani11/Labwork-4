

def calc(a, b, op):
    if op == '+':
        return a + b
    elif op == '-':
        return a - b
    elif op == '*':
        return a * b
    elif op == '/':
        return a / b
    else:
        raise ValueError("Unsupported operation")


print(calc(10, 5, '+'))  
print(calc(10.5, 2, '/'))  


