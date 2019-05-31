using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Prototype.Api.Models;

namespace Prototype.Api.Repositories
{
    public interface IActivityRepository
    {
        Task<Activity> GetAsync(Guid id);
        Task<IEnumerable<Activity>> BrowseAsync(Guid userId);
        Task AddAsync(Activity activity);
    }
}