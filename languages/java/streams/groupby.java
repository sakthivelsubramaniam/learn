package com.learn.java8;

import java.util.Arrays;
import java.util.EnumMap;
import java.util.List;
import java.util.IntSummaryStatistics;
import java.util.Map;
import java.util.function.Function;
import java.util.stream.Collectors;
import java.util.Objects;
import java.util.Optional;
import java.util.Set;
import java.util.concurrent.ConcurrentMap;
import java.util.stream.Collectors.*;

public class GroupBy {

    private static final List<BlogPost> posts = 
      Arrays.asList(new BlogPost("News item 1", "Author 1", BlogPostType.NEWS, 15),
        new BlogPost("Tech review 1", "Author 2", BlogPostType.REVIEW, 5),
        new BlogPost("Programming guide", "Author 1", BlogPostType.GUIDE, 20),
        new BlogPost("News item 2", "Author 2", BlogPostType.NEWS, 35), 
        new BlogPost("Tech review 2", "Author 1", BlogPostType.REVIEW, 15));

    
    public static void main(String[] args) {

        System.out.println("blog post by type ");
        Map<BlogPostType, List<BlogPost>> postsPerType = posts.stream()
        .collect(Collectors.groupingBy(BlogPost::getType));

        System.out.println(postsPerType.get(BlogPostType.NEWS).size()); 
        System.out.println("\n");

        System.out.println("blog post by type ");
        Map<BlogPostType, List<BlogPost>> postsPerType = posts.stream()
        .collect(Collectors.groupingBy(BlogPost::getType));

        System.out.println(postsPerType.get(BlogPostType.NEWS).size()); 
        System.out.println("\n");


        

    }
    
}



public class BlogPost {
    private String title;
    private String author;
    private BlogPostType type;
    private int likes;

    public BlogPost(String title, String author, BlogPostType type, int likes) {
        this.title = title;
        this.author = author;
        this.type = type;
        this.likes = likes;
    }

    public String getTitle() {
        return title;
    }

    public String getAuthor() {
        return author;
    }

    public BlogPostType getType() {
        return type;
    }

    public int getLikes() {
        return likes;
    }

    @Override
    public String toString() {
        return "BlogPost{" + "title='" + title + '\'' + ", type=" + type + ", likes=" + likes + '}';
    }
}

enum BlogPostType {
    NEWS,
    REVIEW,
    GUIDE
}

public class Tuple {
    private final BlogPostType type;
    private final String author;

    public Tuple(BlogPostType type, String author) {
        this.type = type;
        this.author = author;
    }

    public BlogPostType getType() {
        return type;
    }

    public String getAuthor() {
        return author;
    }

    @Override
    public boolean equals(Object o) {
        if (this == o)
            return true;
        if (o == null || getClass() != o.getClass())
            return false;
        Tuple tuple = (Tuple) o;
        return type == tuple.type && author.equals(tuple.author);
    }

    @Override
    public int hashCode() {
        return Objects.hash(type, author);
    }

    @Override
    public String toString() {
        return "Tuple{" + "type=" + type + ", author='" + author + '\'' + '}';
    }
}