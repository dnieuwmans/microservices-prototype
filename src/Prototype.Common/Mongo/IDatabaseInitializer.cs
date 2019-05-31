using System.Threading.Tasks;

namespace Prototype.Common.Mongo
{
    public interface IDatabaseInitializer
    {
        Task InitializeAsync();
    }
}