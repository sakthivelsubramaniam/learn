package com.helper;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.boot.Banner;
import org.springframework.boot.CommandLineRunner;
import org.springframework.boot.SpringApplication;
import org.springframework.boot.autoconfigure.SpringBootApplication;








//import com.helper.service.HelloService;

import static java.lang.System.exit;

@SpringBootApplication
public class ConsoleApplication implements CommandLineRunner {


    public static void main(String[] args) throws Exception {

        SpringApplication app = new SpringApplication(ConsoleApplication.class);
        app.setBannerMode(Banner.Mode.OFF);
        app.run(args);
        SpringApplication.run(ConsoleApplication.class, args);
    }

    @Override
    public void run(String... args) throws Exception {

            System.out.println("cosmos db connection");

            CosmosHelper compos = new CosmosHelper();
            compos.Exeute();

            exit(0);
    }

     // Database Create

}