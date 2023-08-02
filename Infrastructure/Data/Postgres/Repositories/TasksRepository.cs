using Infrastructure.Data.Postgres.Entities;
using Infrastructure.Data.Postgres.EntityFramework;
using Infrastructure.Data.Postgres.Repositories.Base;
using Infrastructure.Data.Postgres.Repositories.Base.Interface;
using Infrastructure.Data.Postgres.Repositories.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Postgres.Repositories
{
    public class TasksRepository : Repository<Tasks, int>, ITasksRepository
    {
        public TasksRepository(PostgresContext postgresContext) : base(postgresContext)
        {
        }

        public async Task AddAsync(Tasks entity)
        {
            await PostgresContext.Set<Tasks>().AddAsync(entity);
            await PostgresContext.SaveChangesAsync();
        }

        public async Task<IList<Tasks>> GetAllAsync(Expression<Func<Tasks, bool>>? filter = null)
        {
            var houses = PostgresContext.Set<Tasks>();
            return filter == null
                ? await houses.ToListAsync()
                : await houses.Where(filter)
                .ToListAsync();
        }

        public Task<IList<Tasks>> GetByTasksIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Tasks entity)
        {
            PostgresContext.Set<Tasks>().Update(entity);
            PostgresContext.SaveChanges();
        }
       
    }
}
