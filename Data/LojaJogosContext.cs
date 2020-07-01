using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LojaJogos.Models;

namespace LojaJogos.Data
{
    public class LojaJogosContext : DbContext
    {
        public LojaJogosContext (DbContextOptions<LojaJogosContext> options)
            : base(options)
        {
        }

        public DbSet<LojaJogos.Models.Produto> Produto { get; set; }

        public DbSet<LojaJogos.Models.Categoria> Categoria { get; set; }

        public DbSet<LojaJogos.Models.Client> Client { get; set; }
    }
}
