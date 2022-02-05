namespace learnfsh

 module customFormatters = 
  open System
  let displayArray  =
      //%[flags][width][.precision]specifier
      printfn "1.display string %s " "hello world"
      printfn "2.display integer %i"  100
      printfn "3.display any values %A"  [|2;4;5|]
      // prints the type info it is similar to object.toring();
      printfn "4.display object info %O"  [|2;4;5|]
      printfn "5.display boolean %b"  true
      printfn "6.display baisc decimal %d %d"  234 -34
      printfn "7.display usigned integer/decimal %u %u"  234 -34
      printfn "8.escapping %%"
      // other printfn
      printfn "9.signed8: %i unsigned8: %u" -1y -1y
      printfn "10.signed16: %i unsigned16: %u" -1s -1s
      printfn "11.signed32: %i unsigned32: %u" -1 -1
      printfn "12.signed64: %i unsigned64: %u" -1L -1L
      printfn "13.uppercase hex: %X lowercase hex: %x octal: %o" 255 255 255
      printfn "14.byte: %i " 'A'B
      // 1.display string hello world
      // 2.display integer 100
      // 3.display any values [|2; 4; 5|]
      // 4.display object info System.Int32[]
      // 5.display boolean true
      // 6.display baisc decimal 234 -34
      // 7.display usigned integer/decimal 234 4294967262
      // 8.escapping %
      // 9.signed8: -1 unsigned8: 255
      // 10.signed16: -1 unsigned16: 65535
      // 11.signed32: -1 unsigned32: 4294967295
      // 12.signed64: -1 unsigned64: 18446744073709551615
      // 13.uppercase hex: FF lowercase hex: ff octal: 377
      // 14.byte: 65

      // optional width
      let pi = 3.14
      printfn "|%f|" pi     // normal
      printfn "|%10f|" pi   // width
      printfn "|%010f|" pi  // zero-pad
      printfn "|%-10f|" pi  // left aligned
      printfn "|%0-10f|" pi // left zero-pad
      // |3.140000|
      // |  3.140000|
      // |003.140000|
      // |3.140000  |
      // |3.14000000|
