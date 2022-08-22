


### blazor azure
1. base info for creating azure resource
	  - Subscription, hosting plan, Resouce group
2. blazor app, 1 cores and 3.5 gb of ram, blazor supports 5000 users.
    with 4 cores and 14 gm of ram supports 20000 users.  
		with latencecy of 200 mili seconds.
3  in app web setting turn web socket on.
4. in publish page, we can configure signal R service
5. Signal R Service, has two flavours
	a. free - supports, 20 concurrent users, 20,000 messge per unit per day, max units 1
	b. standard - supports 1000 users for 1 units with price $ 1.61 per units
							  If we need to support 1000 users then 5 units should be taken
								and 1 $ per million message.
								 
