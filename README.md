# CsvDataApi
REST API returning data from a CSV file.

This solution has 2 projects:
### DataRepository
This uses TinyCsvParser NuGet package to read the CSV file.
The test *baskets* CSV file is stored as a embedded resource. 
BasketProcessor class does the leg work of reading the CSV file and storing it into a *basket* list.

### API
REST API project provides two resources with the following functionality: 
* Retrieve a single basket by *transactionNumber*
* Return all baskets ordered by *CreatedDateTime* descending with an optional filter on *Domain*  

BasketDataService class communicates with DataRepository and returns the data.

## Instructions
1. clone the solution using Visual Studio 2019 or download solution zip file, unzip the solution and open it in Visual Studio 2019
2. right click on API project and select *Set as Startup Project*
3. build the solution and press Ctrl+F5 to run it without debugging. By default all baskets will be returned  
   http://localhost:50860/api/Baskets
4. To return baskets for domain 10:  
http://localhost:50860/api/Baskets/10
5. To return basket for a particular Transaction Number:  
http://localhost:50860/api/Baskets/002e7a2e-653d-424c-a3ed-c287fe3a1666
