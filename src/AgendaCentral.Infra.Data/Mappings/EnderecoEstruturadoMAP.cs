using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AgendaCentral.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgendaCentral.Infra.Data.Mappings
{
    public class EnderecoEstruturadoMAP : IEntityTypeConfiguration<EnderecoEstruturado>
    {
        public void Configure(EntityTypeBuilder<EnderecoEstruturado> builder)
        {
            builder.ToTable("EnderecoEstrurado");

            builder.Property(x => x.Logradouro).HasMaxLength(1000);
        }
    }
}