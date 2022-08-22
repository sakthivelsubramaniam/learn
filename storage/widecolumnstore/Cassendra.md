# cassenddra on 18 April


### objectives 
- Staged event drived architecture.
- it combines best features from Dynamo and Google BigTable.
- Full multi-master replication
- Global availability at low latency
- Linear throughput increase with addition of processor.
- online load balancing and cluster growth.
- partition key oriented queries
- flexable schema

## features
 **Keyspace** : it defines how the data is replicated withing the cluster
 **Tables** : Defines the typed schema for a collection of partition.
 Tables contains Partitions, which contains rows with contains columns.
 

 **Partition**: Rows has a partition key, which identities the node in the clusters where rows are stored.

 **Row**: Contains collection of columns identified by Partition key and optionally clustering key.

 **Materialized View**: 
  It is a view based on base table. Data is kept sync with the table by database.

 **join**: no joins

 **others features**: 
  - Light weight Transactions.
  - Batches

  ## Notes on Modelling 
   In Relational world you start with conceptual domain model, assign primary keys. Identity the relationship, assign foreign key, then identity other data elements

   In Wide Column,you start with Query model, instead of modelling data we need to write the queries and let the data organize around them.


  ## Notes on denormalization
   A second reason that relational databases get denormalized on purpose is a business document structure that requires retention. That is, you have an enclosing table that refers to a lot of external tables whose data could change over time, but you need to preserve the enclosing document as a snapshot in history.

  ## other consideration on designing
   * Need minimize the partition for the queries
   * Sort order of the queries
   * How data is stored on the disk.
