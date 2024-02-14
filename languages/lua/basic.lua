print("begin")
local foo = "foo variable"
print(foo)

io.write("print using io.write")

--[[Local variable declaration ]]
--

local k, m = 5, 19

print(k)
print(m)

--[[using variable in print statement ]]
print("variable in :k", k)

-- enable know the type of the variable
print(type(3))

print(-k)

print("type function", type(k))
print("relation operation", k == 5)
print("relation operation negation", k ~= 5)

--
print("string operation")
local a = "hello"
local b = "world"
print("concatenate two string", a .. b)
print("length of a  string", #a)

----
--
