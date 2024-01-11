namespace DesignPatterns.Factory.V1.Concrete;

class CosmosDb : IDatabase
{
    public List<string> GetUsers()
    {
        return new List<string>
        {
            "CosmosUser1",
            "CosmosUser2"
        };
    }

    public bool IsApplyingTo(DatabaseTypes databaseType)
    {
        return databaseType == DatabaseTypes.CosmosDb;
    }
}