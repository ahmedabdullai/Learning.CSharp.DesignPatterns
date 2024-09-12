using Proxy;

IDatabase databaseProxy = new DatabaseProxy();

// The first query will trigger the connection
databaseProxy.ExecuteQuery("SELECT * FROM Users");

// The second query will not trigger the connection again
databaseProxy.ExecuteQuery("SELECT * FROM Orders");