//namespace DataStructure

module MyFileSystem =
   
   type FileSystemItem =
     | File of FileInfo
     | Directory of DirectoryInfo
   and FileInfo = {Name:string; fileSize:int}
   and DirectoryInfo = {Name:string; fileSize:int; SubItems : FileSystemItem List  }

   let ListInfo (folder:FileSystemItem ) =
       match folder 
        | File f -> printfn "%s" f.Name
        | Folder  fl-> printfn "%s" fl.Name

    

 module Main = 
    open MyFileSystem

    let rootfolder = {
      Name="root folder"; 
      fileSize=12; 
      SubItems = [
        File { Name = "file1"; fileSize=1 };
        File { Name = "file2"; fileSize=1 };
        Directory {
          Name=" folder 1"; 
          fileSize=12; 
          SubItems = [
            File { Name = "file1.1"; fileSize=1 };
            File { Name = "file1.2"; fileSize=1 };
            Directory { Name ="folder1.1"; fileSize=1; SubItems=[] }
            ] 
          }
        ]
      }


    printfn "file is %s" rootfolder.Name 

