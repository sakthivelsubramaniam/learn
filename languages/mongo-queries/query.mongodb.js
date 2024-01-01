use("Learn")
  db.inventory.deleteMany({});

 db.inventory.insertMany([
  {
    item: 'journal',
    qty: 25,
    size: { h: 14, w: 21, uom: 'cm' },
    tags: ['blank', 'red'],
    status: 'A',
    dim_cm: [14, 21]
  },
  {
    item: 'notebook',
    qty: 50,
    size: { h: 8.5, w: 11, uom: 'in' },
    tags: ['red', 'blank'],
    status: 'A',
    dim_cm: [14, 21]
  },
  {
    item: 'Jewels',
    qty: 45,
    size: { h: 10, w: 15.25, uom: 'cm' },
    tags: ['blank', 'red','plain'],
    status: 'A',
    dim_cm: [22.4, 18]
  },
  {
    item: 'paper',
    qty: 100,
    size: { h: 8.5, w: 11, uom: 'in' },
    tags: ['red', 'blank', 'plain'],
    status: 'D',
    dim_cm: [14.4, 15]
  },
  {
    item: 'planner',
    qty: 75,
    size: { h: 22.85, w: 30, uom: 'cm' },
    tags: ['blank', 'red'],
    dim_cm: [ 1,  1.5],
    status: 'D'
  },
  {
    item: 'postcard',
    qty: 45,
    size: { h: 10, w: 15.25, uom: 'cm' },
    tags: ['blue'],
    dim_cm: [1.4, 15],
    status: 'A'
  }
]);

// return all rows
use('Learn')
db.inventory.find({})

// simple query
use('Learn');
db.inventory.find( {
    item : "postcard"
  })

// greater 
use('Learn');
db.inventory.find({"size.h": {"$gt": 8}})


// query an array for exact match (all items and same order)
use('Learn');
db.inventory.find( {
    tags : ["blank","red"]
  })

// array having alteast one item 
use('Learn');
db.inventory.find( {
    tags : "red" 
  })

// array having alteast one item 
use('Learn');
db.inventory.find( {
  "$or":  [ {tags : "blue"}, {tags: "blank"} ]
  })

// using $elemMatch
use('Learn');
db.inventory.find( {
  dim_cm: { $elemMatch: { $gt: 22, $lt: 30 } }
  })


// query an array with all match
  use('Learn');
  db.inventory.find( {
      tags : { "$all": ["blank","red"]}
    })


    
