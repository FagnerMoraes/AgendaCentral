using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgendaCentral.Data.EFCore.Mappings;
using Microsoft.EntityFrameworkCore;
using AgendaCentral.Domain.Entities;

namespace AgendaCentral.Data.EFCore.Context
{
    public class DataContext : DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PessoaMap());
        }

        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<EnderecoEstruturado> EnderecosEstruturados { get; set; }

    }
}
