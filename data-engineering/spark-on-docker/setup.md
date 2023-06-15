# Spart On Docker

## Overview
* Distributing Processing
* In memory computation
* Multi Language


https://hub.docker.com/r/apache/spark-py

## Steps
docker run -it apache/spark-py /opt/spark/bin/pyspark




### Resource
https://hub.docker.com/r/apache/spark-py

https://towardsdatascience.com/spark-and-docker-your-spark-development-cycle-just-got-11x-faster-f41ed50c67fd

https://towardsdatascience.com/diy-apache-spark-docker-bb3f11c10d24a

https://levelup.gitconnected.com/how-to-run-spark-with-docker-c6286a11a437

https://dev.to/mvillarrealb/creating-a-spark-standalone-cluster-with-docker-and-docker-compose-2022-update-6l4

https://cloudinfrastructureservices.co.uk/create-apache-spark-docker-container-using-docker-compose/

https://www.kdnuggets.com/2019/07/apache-spark-cluster-docker.html
https://spot.io/blog/tutorial-running-pyspark-inside-docker-containers/

### Images
 jupyter/pyspark-notebook


## Steps did not work
https://levelup.gitconnected.com/how-to-run-spark-with-docker-c6286a11a437


download the fhv-tripdata-2021-01.csv.gz from (Url)[https://github.com/DataTalksClub/nyc-tlc-data/releases/tag/fhv]

``` Bash

docker build -t spark_docker_v1 .
docker run --rm -it -p 4040:4040 spark_docker_v1

```
After Installation, Python propmt will be shown.



