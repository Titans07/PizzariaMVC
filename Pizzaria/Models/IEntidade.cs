using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pizzaria.Models
{
    public interface IEntidade
    {
        DateTime DataAlteracao { get; set; }
        DateTime DataCadastro { get; set; }
        int Id { get; set; }
    }
}
