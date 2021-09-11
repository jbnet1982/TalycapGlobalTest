using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TalycapGlobalWebAPI.Models
{
    public partial class TalycapGlobalDBContext: DbContext
    {
        public TalycapGlobalDBContext(DbContextOptions<TalycapGlobalDBContext> options)
            : base(options)
        {

        }

        public virtual DbSet<Pai> Pais { get; set; }
        public virtual DbSet<Estado> Estados { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=LAPTOP-VKBJDBVK;Database=TalycapGlobalBD");
            }
        }

    }
}
