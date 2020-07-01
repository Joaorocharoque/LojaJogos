using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LojaJogos.Models;

namespace LojaJogos.Data
{
    public class SeedingService
    {
        private LojaJogosContext _context;

        public SeedingService(LojaJogosContext context)
        {
            _context = context;
        }
        public void Seed()
        { 
            if(  _context.Produto.Any())
            {
                return;
            }
            Categoria cat01 = new Categoria(1, "Ação");
            Categoria cat02 = new Categoria { Id = 2, Nome = "Corrida" };
           
            Produto p1 = new Produto(1, "The Last of Us", 250, 3, cat01);
            Produto p2 = new Produto(2, "God of War", 200, 6, cat01);
            Produto p3 = new Produto(3, "Horizon 4", 180, 14, cat01);

            _context.Categoria.AddRange(cat01, cat02);
            _context.Produto.AddRange(p1, p2, p3);

            _context.SaveChanges();

        }
    }  
}
