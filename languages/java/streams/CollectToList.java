package com.learn.java8;

import java.util.Arrays;
import java.util.List;
import java.util.Map;
import java.util.stream.Collectors;

public class CollectToList {
    public static void main(String[] args) {
        
        //3 apple, 2 banana, others 1
        List<String> items =
                Arrays.asList("apple", "apple", "banana",
                        "apple", "orange", "banana", "papaya");

        List<String> results =
        items.stream()
        .filter(item -> item == "apple")
        .collect(Collectors.toList());

        System.out.println(results);
    }
    
}
