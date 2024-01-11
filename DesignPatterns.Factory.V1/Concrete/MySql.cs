namespace DesignPatterns.Factory.V1.Concrete;

class MySql : IDatabase
{
    public List<string> GetUsers()
    {
        return new List<string>
        {
            "MySqlUser1",
            "MySqlUser2"
        };
    }

    public bool IsApplyingTo(DatabaseTypes databaseType)
    {
        return databaseType == DatabaseTypes.MySql;
    }
}