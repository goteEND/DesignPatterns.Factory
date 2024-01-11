namespace DesignPatterns.Factory.V1.Concrete;

class MongoDB : IDatabase
{
    public List<string> GetUsers()
    {
        return new List<string>
        {
            "MongoUser1",
            "MongoUser2"
        };
    }

    public bool IsApplyingTo(DatabaseTypes databaseType)
    {
        return databaseType == DatabaseTypes.MongoDb;
    }
}