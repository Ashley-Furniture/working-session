# Working Sessions API

Create a simple todo REST api that will fulfill the following:

Given a Todo
When the Object doesn't exist
Then the Todo should be written to a database

Given a Todo
When the Object exists in the database
Then the Todo Should be Updates in the database

Given a Request for a Todo by Id
When the Object exists in the database
Then the Todo should retun the Object

Given a Request for a Todo by Id
When the Object doesn't exit in the database
Then the Todo should return an Error