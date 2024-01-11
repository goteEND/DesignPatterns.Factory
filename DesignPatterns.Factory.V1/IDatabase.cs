namespace DesignPatterns.Factory.V1;

interface IDatabase
{
    List<string> GetUsers();
    bool IsApplyingTo(DatabaseTypes databaseTypes);
}
