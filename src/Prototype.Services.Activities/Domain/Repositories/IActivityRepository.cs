using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Prototype.Services.Activities.Domain.Models;

namespace Prototype.Services.Activities.Domain.Repositories
{
    public interface IActivityRepository
    {
        Task<Activity> GetAsync(Guid id);
        Task AddAsync(Activity activity);
        Task DeleteAsync(Guid id);
    }
}