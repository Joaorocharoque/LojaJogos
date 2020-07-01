using LojaJogos.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LojaJogos.Data;
using LojaJogos.Models;

namespace LojaJogos.Services
{

    public class CategoriaService
    {
        private readonly LojaJogosContext _context;

        public CategoriaService(LojaJogosContext context)
        {
            _context = context;
        }

        public void Inserir(Categoria categoria)
        {
            _context.Add(categoria);
            _context.SaveChanges();
        }


        public List<Categoria> getCategorias()
        {
            return _context.Categoria.ToList();
        }
    }
}
