using CPS.Dal.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CPS.Dal.EntityConfigurations
{
    public class ProjectInfoConfiguration : IEntityTypeConfiguration<ProjectInfo>
    {
        public void Configure(EntityTypeBuilder<ProjectInfo> builder)
        {
            builder.HasKey(t => t.Id);
            builder.HasOne(t => t.FlowState).WithMany(t => t.ProjectInfo).HasForeignKey(t => t.FlowStateId).HasPrincipalKey(t => t.Id);
           
        }
    }
}
