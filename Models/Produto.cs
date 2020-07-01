using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LojaJogos.Models
{
    public class Produto
    {
        public int Id { get; set; }

        public string Nome{ get; set; }

        public double Preco { get; set; }

        public double Quantidade { get; set; }

        public Categoria Categotia { get; set; }

        public int CategoriaId { get; set; }

        public Produto()
        {
        }

        public Produto(int id, string nome, double preco, double quantidade, Categoria categotia)
        {
            Id = id;
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
            Categotia = categotia;
        }
    }
}
