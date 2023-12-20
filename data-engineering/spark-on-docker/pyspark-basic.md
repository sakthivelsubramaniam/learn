# Pyspark

### Resouce (check the downloads)
https://github.com/spark-examples/pyspark-examples/
https://sparkbyexamples.com/pyspark-tutorial/#spyder-ide



### Import SparkSession

``` python

from pyspark.sql import SparkSession

spark = SparkSession.builder \
      .master("local[1]") \
      .appName("SparkByExamples.com") \
      .getOrCreate() 

# Create RDD from parallelize    
dataList = [("Java", 20000), ("Python", 100000), ("Scala", 3000)]
rdd=spark.sparkContext.parallelize(dataList)

# Create RDD from external Data source
rdd2 = spark.sparkContext.textFile("/temp/test.txt")

rdd.Collect() #collects the result and displays

```

### Overview
Two operations of  RDD are 
1. Transformation - Returns the another RDD
      examples are flatmap(), map(), reduceByKey(), filter(), sortbyKey()

2. Actions - Returns the Values from RDD to driver code 
      examples are count(), first(), max(), reduce()

* Transformation are lazy, they will not be executed unit a Action method is called. 

Transformation can 
1. Narrow Transformation
- They are transformation that move data between partitions
      examples
      1. map()
      2. filter()
      3. flatmap()
      4. union()

2. Wide Transformation
- They compute data that live on many partitions
      examples 
      1. groupByKey()
      2. reduceByKey()
       