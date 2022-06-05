using CPS.Dal.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CPS.Dal.EntityConfigurations
{
    public class FlowStateConfiguration : IEntityTypeConfiguration<FlowState>
    {
        public void Configure(EntityTypeBuilder<FlowState> builder)
        {
            builder.HasKey(t => t.Id);
           
        }
    }
}
