x = 10
print(x, type(x))     

x = "ten"
print(x, type(x))     

x = True
print(x, type(x))     


# • What happens in each case?
#       Python allows variable 'x' to change its type freely at runtime.
#      The variable name is just a label that can refer to any object.

# • If the compiler/interpreter allows it, print type(x) or equivalent.
#       type(x) returns the current data type (int, str, bool).
#      Output :
#         <class 'int'>
#         <class 'str'>
#         <class 'bool'>

