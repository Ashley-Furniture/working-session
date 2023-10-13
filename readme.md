# Working Sessions API

# Phase 1

Create a simple todo REST api that will fulfill the following:

Given a Todo    
When the Object doesn't exist in the database
Then the Todo should be written to a database   

Given a Todo    
When the Object exists in the database  
Then the Todo should be updated in the database 

Given a Request for a Todo by Id    
When the Object exists in the database  
Then the Todo should return the Object   

Given a Request for a Todo by Id    
When the Object doesn't exit in the database    
Then the Todo should return an error    

Given a Todo    
When the Object is marked as `Complete`     
Then the Todo should be stored with a Completed Boolean     

# Phase 2

We've been very successful with the todo service, congrats btw. So successul that we need to distribute the application across a pool of nodes.

Given a Todo
When the Object is actively being Edited by a user    
Then other pools in the node should see the Todo in queries     
 and should return the todo in a locked state to all users except the editor

