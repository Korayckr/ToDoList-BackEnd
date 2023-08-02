using Infrastructure.Data.Postgres.Entities;
using Infrastructure.Data.Postgres.Repositories.Base.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Postgres.Repositories.Interface
{
    public interface ITasksRepository : IRepository<Tasks, int>
    {
        Task<IList<Tasks>> GetByTasksIdAsync(int id);
    }
}
