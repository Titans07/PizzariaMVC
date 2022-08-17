using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pizzaria.Models
{
    public class Tamanho : IEntidade
    {
        public Tamanho(string nome)
        {
            DataAlteracao = DataCadastro;
            DataCadastro = DateTime.Now;
            Nome = nome;
        }

        public DateTime DataAlteracao { get; set; }
        public DateTime DataCadastro { get; set; }
        public int Id { get; set; }
        public string Nome { get; set; }
        public List<Pizza> Pizzas { get; set; }

        public void AlterarDados(string nome)
        {
            Nome = nome;
        }
    }
}
