using System.Threading.Tasks;

namespace Prototype.Common.Mongo
{
    public interface IDatabaseSeeder
    {
         Task SeedAsync();
    }
}