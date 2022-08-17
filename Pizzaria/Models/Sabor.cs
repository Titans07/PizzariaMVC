using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pizzaria.Models
{
    public class Sabor : IEntidade
    {
        public Sabor(string fotoURL, string nome)
        {
            DataAlteracao = DataCadastro;
            DataCadastro = DateTime.Now;
            FotoURL = fotoURL;
            Nome = nome;
        }

        public DateTime DataAlteracao { get; set; }
        public DateTime DataCadastro { get; set; }
        public string FotoURL { get; set; }
        public int Id { get; set; }
        public string Nome { get; set; }
        public List<PizzaSabor> PizzaSabor { get; set; }

        public void AlterarDados(string fotoURL, string nome)
        {
            Nome = nome;
            FotoURL = fotoURL;
            DataAlteracao = DateTime.Now;
        }

    }
}
