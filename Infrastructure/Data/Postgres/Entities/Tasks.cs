using Infrastructure.Data.Postgres.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Postgres.Entities;

    public class Tasks : Entity<int>
    {
        public int UserId { get; set; }

        public string TaskName { get; set; } = default!;
        public string TaskDesc { get; set; } = default!;
        public int Time { get; set; } = default!;
        public statusType status { get; set; } = default!;


    public User User { get; set; } = default!;

    }


public enum  statusType
{
  NotComplated,
  Complated,


}
