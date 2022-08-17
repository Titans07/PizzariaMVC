using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pizzaria.Models
{
    public class Pizza : IEntidade
    {
        public Pizza(string fotoURL, string nome, decimal preco, int tamanhoId)
        {
            DataAlteracao = DataCadastro;
            DataCadastro = DateTime.Now;
            FotoURL = fotoURL;
            Nome = nome;
            Preco = preco;
            TamanhoId = tamanhoId;
        }

        public DateTime DataAlteracao { get; set; }
        public DateTime DataCadastro { get; set; }
        public string FotoURL { get; set; }
        public int Id { get; set; }
        public string Nome { get; set; }
        public List<PizzaSabor> PizzaSabor { get; set; }
        public decimal Preco { get; set; }
        public Tamanho Tamanho { get; set; }
        public int TamanhoId { get; set; }

        public void AlterarDados(string nome, decimal preco, int tamanhoId, string fotoURL)
        {
            Nome = nome;
            Preco = preco;
            FotoURL = fotoURL;
            TamanhoId = tamanhoId;
            DataAlteracao = DateTime.Now;
        }
    }
}
