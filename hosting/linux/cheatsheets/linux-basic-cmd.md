Command | description 
---|---
**locaion** | 
pwd | current location  
cd ~ | ~ alias for home
**env variable**|
$HOME| home directory
$SHELL | current shell that is being used
$PATH | same function as in windows
**Pattern**|
*[1-5]* | matches string any that contains 1 to 5 number  
**install app** | 
sudo apt install [app name] | to install the application 
**help**|
man [command] | linux manual for commands
info <command> | verbose help on linux command
man man | help on manual 
**pager**|
less | generally operates the content of the file or pipe output
more | similar to less
**File**|
ls <pattern> | list the directory 
ls -a | list all the items in a directory
ls -l | in long format
ls -ltr | in reverse order
file <fileName> | file type of the file 
mv | moves the files to target folder
cp | copy the files to target folder
cp -R | copu the files recursivly 
rm | remove the files
**folder**|
mkdir <folderName> | creates a folder
mkdir -p <folderName>/<child1>/<child2> | creates  sub folders
rm -D <folderName> | removes empty directory
rmdir  | removes empty directory
rm -r  | removes non empty directory and child directory
**view file context**|
cat file1 file2 file3 | to cancadindate the files and view in STD
**Search**|
which <command/exe> | give the path in which command/exe is located
find <path> -name <searchstring> | path gives location to the search the search string 
grep <searchpattern> <path>| filtering input lines and returning certain pattern in output
backslash | escape charector
**Process**|
[process] & | to run the process in backgroud
pstree | list the processs in tree formant 
ps | list the process
kill | sends the signal to end the process 
kill -1 | list the signals


