using System.Collections.Generic;
using System.Threading.Tasks;
using Prototype.Services.Activities.Domain.Models;

namespace Prototype.Services.Activities.Domain.Repositories
{
    public interface ICategoryRepository
    {
         Task<Category> GetAsync(string name);
         Task<IEnumerable<Category>> BrowseAsync();
         Task AddAsync(Category category);
    }
}