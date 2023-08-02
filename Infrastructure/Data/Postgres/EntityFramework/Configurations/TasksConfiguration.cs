using System;
using Infrastructure.Data.Postgres.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrastructure.Data.Postgres.EntityFramework.Configurations.Base;

namespace Infrastructure.Data.Postgres.EntityFramework.Configurations
{
    public class TasksConfiguration : BaseConfiguration<Tasks, int>
    {
        public override void Configure(EntityTypeBuilder<Tasks> builder)
        {

            base.Configure(builder);

            builder.Property(t => t.TaskName).IsRequired();
            builder.Property(t => t.TaskDesc).IsRequired();
            builder.Property(t => t.Time).IsRequired();
            builder.Property(t => t.status).IsRequired();


            builder.HasOne(x => x.User)
                .WithMany(t => t.Tasks)
                .HasForeignKey(t => t.UserId);
        }


    }
}
