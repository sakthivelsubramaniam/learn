
# to directly execute java file
java  HelloString.java


# to compile byte code and execute java.class 
javac HelloString.java
java  HelloString

# to specify the class path and execute 

java -classpath [classpath] compilefileName

# to create jar file

jar --create --file helloJar.jar HelloString.class 
jar cf helloJar.jar HelloString.class 

# working with manifest

jar --create --file helloJar.jar --manifest mymanifest -C foo/ .
