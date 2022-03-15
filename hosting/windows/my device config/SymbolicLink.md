A symbolic link is a file-system object that points to another file system object. The object being pointed to is called the target.


A symbolic link can also contain both junction points and mounted folders as a part of the path name.

Symbolic links can point directly to a remote file or directory using the UNC path.

There are two types of links supported in the NTFS file system: hard links and junctions.

The NTFS file system also provides the distributed link tracking service, which automatically tracks links as they are moved

HardLinks: 
A hard link is the file system representation of a file by which more than one path references a single file in the same volume. To create a hard link, use the CreateHardLink function. Any changes to that file are instantly visible to applications that access it through the hard links that reference it. 

Juctions:  
Creates a soft link

```batch

// to create a soft link
mklink Link Target

// to create a soft link director
mklink /D link Target

// Hard link poiting to a file
mklink /H link Target

// Hard link pointing to direcotry
mklink /J link target





```



