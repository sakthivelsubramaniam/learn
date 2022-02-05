--user defined types
-- use data keyword in front of type name 
-- constructors
-- data constructors yield a value
-- type constructors yield a type

data Color = Red | Green | Blue | Indigo | Violet

data Bool               = False | True

-- LHS Point denotes type
-- RHS Point denotes constructor functions
data Point a            = Point a a

-- Constructor function can take different name 
data Point a = Pt a a

-- there can be multiple constructor function with different names
data Shape = Circle Float Float Float | Rectangle Float Float Float Float 

-- to print in console it has to deriving Type Class
data Category = Stationary | Chemicals | Micesslanous deriving (Show) 

data Item = Item { name::String
                 , category::Category
                 , price::Integer
                 , minQty::Integer
               } deriving (Show)  

getItem =
    Item "pencil" Stationary 10 100
