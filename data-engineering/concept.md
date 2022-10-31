
Data pipeline :
 Workflow management tools like Airflow and Luigi arrange the processes of building data pipelines. These open-source tools help developers to organize data workflows

 DPaaS platforms
    Daton is a simple data pipeline
--------
Building an efficient data pipeline is a simple six-step process that includes:

Cataloging and governing the data, enabling access to trusted and compliant data at scale across the enterprise.

Efficiently ingesting the data from various sources such as on-premises databases or data warehouses, SaaS applications, IoT sources, and streaming applications into a cloud data lake.

Integrating the data by cleansing, enriching, and transforming it by creating zones such as a landing zone, enrichment zone, and an enterprise zone.

Detect schema drift in RDBMS schema in the source database or a modification to a table, such as adding a column or modifying a column size and automatically replicating the target changes in real time for data synchronization and real-time analytics use cases

Applying data quality rules to cleanse and manage data while making it available across the organization to support DataOps.

Preparing the data to ensure that refined and cleansed data moves to a cloud data warehouse for enabling self-service analytics and data science use cases.

Stream processing to derive insights from real-time data coming from streaming sources such as Kafka and then moving it to a cloud data warehouse for analytics consumption.
--------------
There are many data processing pipelines. One may:

“Integrate” data from multiple sources
Perform data quality checks or standardize data
Apply data security-related transformations, which include masking, anonymizing, or encryption
Match, merge, master, and do entity resolution
Share data with partners and customers in the required format, such as HL7Data pipeline 
“Integrate” data from multiple sources
------------------------------------
Diff types of  pipeline
----
### Data qaulity pipeline

As a data engineer, you may run the pipelines in batch or streaming mode – depending on your use case. Standardizing names of all new customers once every hour is an example of a batch data quality pipeline. Validating the address of a customer in real time as part of approving a credit card application is an example of a real-time data quality pipeline.

### Data Exchange Pipelinee
You may also receive complex structured and unstructured documents, such as NACHA and EDI documents, SWIFT and HIPAA transactions, and so on. You can receive documents from partners for processing or process documents to send out to partners. This is an example of a B2B data exchange pipeline.

### master data management pipeline
Data matching and merging is a crucial technique of master data management (MDM). This technique involves processing data from different source systems to find duplicate or identical records and merge records in batch or real time to create a golden record, which is an example of an MDM pipeline.data quality pipeline
B2B data exchange pipeline.

--------------

### tools 
### batch processing
Informatica PowerCenter
IBM InfoSphere DataStage
Talend

### Cloud-native
Blendo
Confluent

### Streaming
Apache Kafka
Apache Airflow

Confluent
Havo data
Streamsets

-------
