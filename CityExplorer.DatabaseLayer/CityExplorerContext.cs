using System.Data.Entity;
using CityExplorer.Model;
namespace CityExplorer.DatabaseLayer
{
    public class CityExplorerContext :DbContext
    {
            public DbSet<Person> Person { get; set; }
    }
}
