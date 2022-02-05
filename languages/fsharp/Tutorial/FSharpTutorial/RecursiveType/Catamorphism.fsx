
module Catamorphism =

    type Book = {title:string;price:decimal}

    type Chocolatetype = Dark|Milk|Fusion

    type Chocolate = {ChocType:Chocolatetype;price:decimal}

    type WrappingPapperStyle = 
        |HappyBirthday
        |HappyHoliday
        |SolidColor

    type Gift =
        | Book of Book
        | Chocolate of Chocolate
        | Boxed of Gift
        | Wrapped of Gift*WrappingPapperStyle
        | WithACard of Gift*message:string

    let rec description gift =
        match gift with
        | Book book -> sprintf "%s Title" book.title
        | Chocolate chocolate-> sprintf "%A chocolate" chocolate
        | Wrapped (innerGift,style) -> sprintf "%s gift name %A" (description innerGift) style
        | Boxed boxed -> sprintf "%s in a box" (description boxed)
        | WithACard (innerGift,cardMessage) -> sprintf "%s with card named %s" (description innerGift) cardMessage 

    let rec totalCost gift =
        match gift with
        | Book book ->  book.price
        | Chocolate chocolate->  chocolate.price
        | Wrapped (innerGift,style) ->  (totalCost innerGift) + 10m
        | Boxed innerGift  ->  (totalCost innerGift) + 5m
        | WithACard (innerGift,cardMessage) -> (totalCost innerGift) + 15m 

    let rec whatsInside gift =
        match gift with 
        | Book book -> 
            "A book"
        | Chocolate choc -> 
            "Some chocolate"
        | Wrapped (innerGift,style) -> 
            whatsInside innerGift
        | Boxed innerGift -> 
            whatsInside innerGift
        | WithACard (innerGift,message) -> 
            whatsInside innerGift

    let rec cataGift fBook fChocolate fWrapped fBox fCard gift =
        let recurse = cataGift fBook fChocolate fWrapped fBox fCard
        match gift with 
        | Book book -> 
            fBook book
        | Chocolate choc -> 
            fChocolate choc
        | Wrapped (gift,style) -> 
            fWrapped (recurse gift,style)
        | Boxed gift -> 
            fBox (recurse gift) 
        | WithACard (gift,message) -> 
            fCard ((recurse gift),message)  


module taggedUnionUseage =
    open taggedUnion;
    
    let myBookGift = {title="Wolf Hall";price=400.00m}
    let myChochGift = {ChocType=Dark;price=10m}
    let myWrapped = Wrapped((Book myBookGift), SolidColor)

    let myGiftWithCard = WithACard(myWrapped,"happy birthday dear ")
    let dis = description  myGiftWithCard
    let cost = totalCost myGiftWithCard
    printf "cost of %s is %A" dis cost




        


    
      


