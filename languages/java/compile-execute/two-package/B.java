/*
 javac -d . A.java
 javac -d . B.java
 java mypack.B

*/

package mypack;  
import pack.*;  
  
class B{  
  public static void main(String args[]){  
   A obj = new A();  
   obj.msg();  
  }  
}  