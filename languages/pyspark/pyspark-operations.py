
# PySpark Operation


# Create RDD from parallelize    

dataList = [("Java", 20000), ("Python", 100000), ("Scala", 3000)]
rdd=spark.sparkContext.parallelize(dataList)
rdd.collect()

#take and first()
rdd.first()
rdd.take(2)

#filter 
rdd.filter(lambda x: x[1]==20000).collect()
rdd.filter(lambda x: x[1] >= 20000 and x[0] == "Java").collect()
rdd.filter(lambda x: x[1] == 20000 or x[0] == "Scala").collect()

#map
rdd.map(lambda x: (x[1], x[0])).collect()
rdd.map(lambda x: x[1]).collect() # maps single element

#fold
from operator import add
foldRes=rdd.fold(0, add)
print(foldRes) # output 20


#union rdd

dataList = [("Java", 20000), ("Python", 100000), ("Scala", 3000)]
dataList1 = [("CSharp", 20000), ("FSharp", 100000), ("TypeScript", 3000)]

rdd1=spark.sparkContext.parallelize(dataList)
rdd2=spark.sparkContext.parallelize(dataList2)
unionRdd = rdd1.union(rdd2)
##
unionRdd = spark.sparkContext.union([rdd1,rdd2])

#intersection

dataList = [("Java", 20000), ("Python", 100000), ("Scala", 3000)]
dataList1 = [("CSharp", 20000), "Python", 100000), ("TypeScript", 3000)]

rdd1=spark.sparkContext.parallelize(dataList)
rdd2=spark.sparkContext.parallelize(dataList2)
unionRdd = rdd1.intersection(rdd2)


#subtract- returns elements only in rdd1

dataList = [("Java", 20000), ("Python", 100000), ("Scala", 3000)]
dataList1 = [("CSharp", 20000), "Python", 100000), ("TypeScript", 3000)]

rdd1=spark.sparkContext.parallelize(dataList)
rdd2=spark.sparkContext.parallelize(dataList2)
resultRdd = rdd1.subtract(rdd2)

