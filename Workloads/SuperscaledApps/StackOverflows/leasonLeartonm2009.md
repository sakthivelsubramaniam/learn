# Leason Learnt

* If you’re comfortable managing servers then buy them. The two biggest problems with renting costs were: 1) the insane cost of memory and disk upgrades 2) the fact that they [hosting providers] really couldn’t manage anything.
* Make larger one time up front investments to avoid recurring monthly costs which are more expensive in the long term.
* Update all network drivers. Performance went from 2x slower to 2x faster.
* Upgrading to 48GB RAM required upgrading MS Enterprise edition.
Memory is incredibly cheap. Max it out for almost free performance. At Dell, for example, upgrading from 4G memory to 128G is $4378.
* Stack Overflow copied a key part of the Wikipedia database design. This turned out to be a mistake which will need massive and painful database refactoring to fix. The refactorings will be to avoid excessive joins in a lot of key queries. This is the key lesson from giant multi-terabyte table schemas (like Google’s BigTable) which are completely join-free. This is significant because Stack Overflow's database is almost completely in RAM and the joins still exact too high a cost.
* CPU speed is surprisingly important to the database server. Going from 1.86 GHz, to 2.5 GHz, to 3.5 GHz CPUs causes an almost linear improvement in typical query times. The exception is queries which don’t fit in memory.
* When renting hardware nobody pays list price for RAM upgrades unless you are on a month-to-month contract.
* The bottleneck is the database 90% of the time.
* At low server volume, the key cost driver is not rackspace, power, bandwidth, servers, or software; it is NETWORKING EQUIPMENT. You need a gigabit network between your DB and Web tiers. Between the cloud and your web server, you need firewall, routing, and VPN devices. The moment you add a second web server, you also need a load balancing appliance. The upfront cost of these devices can easily be 2x the cost of a handful of servers.
* EC2 is for scaling horizontally, that is you can split up your work across many machines (a good idea if you want to be able to scale). It makes even more sense if you need to be able to scale on demand (add and remove machines as load increases / decreases).
* Scaling out is only frictionless when you use open source software. Otherwise scaling up means paying less for licenses and a lot more for hardware, while scaling out means paying less for the hardware, and a whole lot more for licenses.

* RAID-10 is awesome in a heavy read/write database workload.
* Separate application and database duties so each can scale independently of the other. Databases scale up and the applications scale out.
* Applications should keep state in the database so they scale horizontally by adding more servers.
* The problem with a scale up strategy is a lack of redundancy. A cluster ads more reliability, but is very expensive when the individual machines are expensive.
* Few applications can scale linearly with the number of processors. Locks will be taken which serializes processing and ends up reducing the effectiveness of your Big Iron.
* With larger form factors like 7U power and cooling become critical issues. Using something between 1U and 7U might be easier to make work in your data center.
* As you add more and more database servers the SQL Server license costs can be outrageous. So by starting scale up and gradually going scale out with non-open source software you can be in a world of financial hurt.
i