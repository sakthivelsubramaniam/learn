
module FileSystemDomain =

    type FileSystemItem = 
       |File of File      
       |Directory of Directory 
    and File = {name:string;fileSize:int}
    and Directory = {name:string;dirSize:int;subitems:FileSystemItem List}

    let readme = File {name="readme.txt"; fileSize=1}
    let config = File {name="config.xml"; fileSize=2}
    let build = File {name="build.bat"; fileSize=3}
    let src = Directory {name="src"; dirSize=10; subitems=[readme; config; build]}
    let bin = Directory {name="bin"; dirSize=10; subitems=[]}
    let root = Directory {name="root"; dirSize=5; subitems=[src; bin]}

    let rec cataFS fFile fDir item : 'r =
        let recurse = cataFS fFile fDir
        match item with
        | File file -> fFile file
        | Directory dir ->
            let listOfRs = dir.subitems |> List.map recurse
            fDir(dir.name,dir.dirSize,listOfRs)

    let totalSize fileSystemItem =
        let fFile (file:File) =
            file.fileSize
        let fDir (name,size,subitemSizes) =
            (List.sum subitemSizes) + size
        cataFS fFile fDir fileSystemItem 


    readme |> totalSize |> printf "readme %d"   // 1
    src |> totalSize    |> printf "src %d" // 16 = 10 + (1 + 2 + 3)
    root |> totalSize   |> printf "root %d"// 31 = 5 + 16 + 10    ;;

     