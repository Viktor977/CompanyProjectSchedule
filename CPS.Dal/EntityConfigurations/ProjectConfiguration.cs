using CPS.Dal.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CPS.Dal.EntityConfigurations
{
    public class ProjectConfiguration : IEntityTypeConfiguration<Project>
    {
        public void Configure(EntityTypeBuilder<Project> builder)
        {
            builder.Property(t => t.ProjectName).HasMaxLength(200);        
            builder.Property(t => t.DateStart).HasMaxLength(30);

            builder.HasOne(t => t.CarentTeam).WithMany(t => t.Project).HasForeignKey(t => t.TeamId).HasPrincipalKey(t => t.Id);
            builder.HasOne(t => t.ProjectInfo).WithOne(t => t.Project).HasForeignKey<ProjectInfo>(t => t.ProjectId);
        }
    }
}
