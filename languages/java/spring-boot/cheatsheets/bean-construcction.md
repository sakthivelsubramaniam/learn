
 # Registration the spring object to container

## configuration

@configuration -  indicates that class primary purpose is as a source of bean definitions
@bean -  that a method instantiates, configures, and initializes a new object to be managed by the Spring IoC container.

 * @bean - can be used for any @commponent
 * bean name is same as method name.
 *  

 ``` java

@Configuration
public class AppConfig {

    @Bean
    public MyService myService() {
        return new MyServiceImpl();
    }
}

 ```
 ## commponent scan
 @commponentscan - scans the namespace/package mentioned in the annotation and adds any class annotated with @component to the container
 
 ``` java
 @Configuration
@ComponentScan(basePackages = "com.acme") 
public class AppConfig  {
    ...
}
 ```


 # initializing spring object
 ## initializing spring object using AnnotationConfigApplicationContext

 ``` java
public static void main(String[] args) {
    ApplicationContext ctx = new AnnotationConfigApplicationContext(AppConfig.class);
    MyService myService = ctx.getBean(MyService.class);
    myService.doStuff();
}

 ```
 * not limited to initializing the @configuration classes, @component class can be used for initializing the class
 * 

 
 ``` java
 public static void main(String[] args) {
    ApplicationContext ctx = new AnnotationConfigApplicationContext(MyServiceImpl.class, Dependency1.class, Dependency2.class);
    MyService myService = ctx.getBean(MyService.class);
    myService.doStuff();
}
 
 ```


