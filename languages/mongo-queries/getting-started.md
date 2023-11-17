# Mongo db getting started


### creating the collection

``` Json
db.myNewCollection2.insertOne( { x: 1 } )
db.myNewCollection3.createIndex( { y: 1 } )

```

### explicit creation

``` Json
  db.createCollection()
 
  
```

### get info about active collection

``` Json
  db.getCollectionInfos()
  
```


### insert the records into the collection

``` Json
db.students.insertOne(
    {
        name: "sakthi",
        age: 23,
        status: "pending"
    }
)

```

### read 

``` json

db.students.find({age : { "$gt": 18 } })

```

### update

``` json

db.students.updateMany(
    { age : { "$gt": 18 } },
    {"$set" : {status : "reject"}}
)

```

### delete

``` json
db.students.deleteMany(
    { status : "reject" }

)

```