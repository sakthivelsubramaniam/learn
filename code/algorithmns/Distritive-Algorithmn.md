

 
distributed algorithm
---
terms and preconidtion: 
1. Write a head log 
2. Persistance storage associated with each relica's
3. There will three phase, Prepare phase,??
4. Number of Nodes
5. Quaram : Majority of nodes in cluster
6. Generation clock, whenever a new leader is selected, a number is updated. 
7. Replicas are preassigned with unique id, assignment is done through configuration.
8.  
 
 scenarios :  
 1.  When replica set is first initialized and other nodes are yet to start.
 2.  When request to update an items and if the recieved generationid is greater than nodes generation.
 3.  

 Algorithmn
 ----
  List of nodes id and address 
  Leader :      
  Generation : 

   

 2 . Loads the configuration 
      post condition: 
      - gets the unique id.
      - knows the other participant id and address.

   
 3. creates a sessionLeader = A 
    Generation 1
    iterates the list of nodes 
      send proposal.
        info: current state ( generation, leader)
              proposed state ( generaioon, leader)

 4. receiver can reject the proposal 
     when reciever's generation > proposer's generation
