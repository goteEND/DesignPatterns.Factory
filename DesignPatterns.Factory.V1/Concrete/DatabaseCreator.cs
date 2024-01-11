using DesignPatterns.Factory.V1.Concrete;

namespace DesignPatterns.Factory.V1;

class DatabaseCreator : IDatabaseCreator
{
  private readonly List<IDatabase> _databases;

  public DatabaseCreator()
  {
    _databases = new List<IDatabase>{
            new MongoDB(),
            new MySql(),
            new CosmosDb()
        };
  }

  public IDatabase Create(DatabaseTypes type)
  {
    return _databases.First(x => x.IsApplyingTo(type));
  }
}