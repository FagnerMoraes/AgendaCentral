using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using AgendaCentral.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgendaCentral.Domain.Enums;

namespace AgendaCentral.Data.EFCore.Mappings
{
    public class PessoaMap : IEntityTypeConfiguration<Pessoa>
    {
        public void Configure(EntityTypeBuilder<Pessoa> builder)
        {

            builder.ToTable("Pessoa");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Nome).HasMaxLength(200).IsRequired();

            builder.Property(x => x.NomeDaMae).HasMaxLength(200).IsRequired();

            builder.Property(x => x.NomeDoPai).HasMaxLength(200);

            builder.Property(x => x.Sexo).HasConversion(
                v => v.ToString(), v => (Sexo)Enum.Parse(typeof(Sexo),v));


        }
    }
}
