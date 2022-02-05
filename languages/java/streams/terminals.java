package com.learn.java8;

import java.util.Arrays;
import java.util.List;
import java.util.Map;
import java.util.stream.Collectors;
import java.util.collection.*;
import java.util.stream;

public class terminals {

    public static void main(String[] args) {

        List<String> items =
                Arrays.asList("apple", "apple", "banana",
                        "apple", "orange", "banana", "papaya");

        
        System.out.println(" ##### foreach ####"); 
        items.stream()
        .forEach(System.out::println);

        System.out.println("\n ##### Aggregate function ####");
        System.out.println(" aggregate function of stream " + items.stream().count());
        System.out.println("\n  ##### distinct ####");
        items.stream().distinct().forEach(System.out::println);

        System.out.println("\n  ##### To List ####");
        List<String> lists = items.stream().collect(Collectors.toList());
        lists.forEach(System.out::println);

        //collectors for joining the string
        System.out.println("\n  ##### To joining the string ####");
        String value = Stream.of("a","b","c","d")
        .collect(Collectors.joining());
         System.out.println(value);

        // collectors for appending the string
        System.out.println("\n  ##### for  string ####");


    }
}
