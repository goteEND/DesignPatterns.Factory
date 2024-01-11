namespace DesignPatterns.Factory.V1;
class Program
{
    static readonly IDatabaseCreator databaseCreator = new DatabaseCreator();
    static void Main(string[] args)
    {
        IDatabase mongoDb = databaseCreator.Create(DatabaseTypes.MongoDb);
        IDatabase mySql = databaseCreator.Create(DatabaseTypes.MySql);
        IDatabase cosmosDb = databaseCreator.Create(DatabaseTypes.CosmosDb);

        var mongoDbUsers = mongoDb.GetUsers();
        foreach (var user in mongoDbUsers)
        {
            Console.WriteLine(user);
        }

        var mySqlDbUsers = mySql.GetUsers();
        foreach (var user in mySqlDbUsers)
        {
            Console.WriteLine(user);
        }

        var cosmosDbUsers = cosmosDb.GetUsers();
        foreach (var user in cosmosDbUsers)
        {
            Console.WriteLine(user);
        }

    }
}
