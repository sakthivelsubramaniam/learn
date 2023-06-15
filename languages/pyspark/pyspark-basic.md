# Pyspark

### Resouce (check the downloads)
https://sparkbyexamples.com/pyspark-tutorial/#spyder-ide
https://github.com/spark-examples
https://github.com/spark-examples/pyspark-examples/
https://github.com/spark-examples/spark-scala-examples


## Steps
docker run -it apache/spark-py /opt/spark/bin/pyspark

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
# Copy the sample1.txt from current folder to temp
rdd2 = spark.sparkContext.textFile("/temp/sample1.txt")

rdd.Collect() #collects the result and displays

```
