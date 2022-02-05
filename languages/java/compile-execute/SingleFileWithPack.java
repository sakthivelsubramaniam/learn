/*
# to compile byte code and execute java.class 
javac -d directory javafilename  
javac -d . SingleFileWithPack.java
java  helloJava.SingleFileWithPack
*/

package helloJava;

class SingleFileWithPack {
    public static void main(String args[]){ 
       
        String myStr = "Hello";
        System.out.println("hello single file app inside the package ");

    }
}