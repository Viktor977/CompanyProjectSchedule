using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CPS.Dal.EntityConfigurations
{
    public class ProjectInfoConfiguration : IEntityTypeConfiguration<ProjectConfiguration>
    {
        public void Configure(EntityTypeBuilder<ProjectConfiguration> builder)
        {
            throw new NotImplementedException();
        }
    }
}
