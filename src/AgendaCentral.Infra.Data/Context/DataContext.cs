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
        public DataContext()
        {
        }
        public DataContext(DbContextOptions options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new PessoaMap());
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {   
        optionsBuilder.UseSqlite(connectionString: "DataSource=app.db;Cache=Shared");

        
    }


        public DbSet<Pessoa> Pessoas { get; set; }
        //public DbSet<EnderecoEstruturado> EnderecosEstruturados { get; set; }

    }
}
