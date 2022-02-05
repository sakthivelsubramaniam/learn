module Folds =

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

    
    let rec foldGift fbook fchoc fboxed fwrapped fwithCard gift =
        let recurse = foldGift fbook fchoc fboxed fwrapped fwithCard
        match gift with
        | Book book -> fbook book
        | Chocolate choc -> fchoc choc
        | Boxed gift -> fboxed (recurse gift)
        | Wrapped (gift,style) -> fwrapped ((recurse gift),style)
        | WithACard (gift,message) ->  fwithCard (recurse gift,message)


    let totalCost gift = 
        let fbook (book:Book) =
            book.price
        let fchoc (choc:Chocolate) =
            choc.price
        let fboxed (innerCost) =
            innerCost + 0.5m
        let fwrapped (innerCost,style:WrappingPapperStyle) =
            innerCost + 1.5m
        let fwithCard (innerCost,msg:string) =
            innerCost + 2.0m
        foldGift fbook fchoc fboxed fwrapped fwithCard gift

    

        
