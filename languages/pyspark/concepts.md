# Pyspark Concepts

### Overview

RDD is created by operation like 
1. parallelize
2. textFile
3. WholeTextFile
Or it can also be created by referencing the source file system.

- Parallelize is Used only in POC as it requires all the data present in the driver program prior to creating RDD.
- referencing the source file system is preferred way to create RDD in Production.


### Operations
Two operations of  RDD are 
1. Transformation - Returns the another RDD  
      examples are flatmap(), map(), reduceByKey(), filter(), sortbyKey()

2. Actions - Returns the Values from RDD to driver code  
      examples are count(), first(), max(), reduce()

* Transformation are lazy, they will not be executed unit a Action method is called. 

Transformation can 
1. Narrow Transformation
- They are transformation that will not  move data between partitions
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

### Repartition
when parallelize, textFile, wholeTextFile are used, the spark splits the data into partitioned based on resource availability.


### Shuffling
Shuffling is a mechanism Spark uses to redistribute the data across different executors and even across machines. Spark shuffling triggers when we perform certain transformation operations like gropByKey(), reduceByKey(), join() on RDDS

### Utility functions
getNumPartitions: returns the number of partition.  


### Transformation

filter
map
flatmap
distinct()
sort
sortByKey
groupByKey
aggregateByKey


### Actions
fold()
reduce()
collect()
foreach()
count()

### Types of RDD
There are different types of RDD as follows
1.  Paired RDD
2.  ShuffledRDD
3.  DoubleRDD
4.  SequenceFileRDD
5.  HadoopRDD
6.  ParallelCollectionRDD

### Paired RDD
It is key-value pair, it is mostly used RDD. Can be created by using map as follows

``` python

pairRdd = rdd.map(lambda x: (x.key, x.value))

```

### SparkContext.parallelize()

``` python

spark.sparkContext.parallelize(dataList)

spark.sparkContext.parallelize(dataList,noOfPartition) # manually used to create number of partitioned.

```
