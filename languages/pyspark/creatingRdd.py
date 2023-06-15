

# creating Rdd
rdd1 = spark.sparkContext.parallelize(datalist)

rdd2 = spark.sparkContext.textFiles("/path/textFile.txt")

rdd3 = spark.sparkContext.wholeTextFiles("/path/textFile.txt")

rdd = spark.sparkContext.emptyRDD # creates EmptyRDD[0]
rddString = spark.sparkContext.emptyRDD[String] # creates EmptyRDD[1]

## Create empty RDD with partition
rdd2 = spark.sparkContext.parallelize(Seq.empty[String])

## Reparitioning the data

rdd2 = rdd1.repartition(4)
