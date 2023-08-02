using Infrastructure.Data.Postgres.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Request.Create
{
    public class CreateTaskDTO
    {
        public int UserId { get; set; }

        public string TaskName { get; set; } = default!;
        public string TaskDesc { get; set; } = default!;
        public int Time { get; set; } = default!;

        


  }
}
