# 1.
a = 5          # int
b = "5"        # str
c = 5.0        # float

# 2.
print(a + c)          
print(a + b)          
print(b + str(c))     


print(a + int(b))     
print(float(a) + c)   
print(str(a) + b)   

# 3.
# 1) Which fail and why?
#   a + b fails because Python does not implicitly convert between numbers and strings.
# 2) Which language allows implicit coercion and how safely?
#   Python only coerces compatible numeric types (int ↔ float), not strings.
# 3) What does this tell you about strong vs weak typing?
#   Python is strongly typed and dynamically typed — conversions must be explicit.
