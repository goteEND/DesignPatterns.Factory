namespace DesignPatterns.Factory.V1;

interface IDatabaseCreator
{
    IDatabase Create(DatabaseTypes type);
}