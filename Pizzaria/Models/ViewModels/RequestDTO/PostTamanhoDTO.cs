using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Pizzaria.Models.ViewModels.RequestDTO
{
    public class PostTamanhoDTO
    {
        [Required(ErrorMessage = "Tamanho é obrigatório")]
        public string Nome { get; set; }
    }
}
