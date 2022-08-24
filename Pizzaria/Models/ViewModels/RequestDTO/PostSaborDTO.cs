using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Pizzaria.Models.ViewModels.RequestDTO
{
    public class PostSaborDTO
    {
        [Required(ErrorMessage = "Imagem obrigatória")]
        public string FotoURL { get; set; }

        [Required(ErrorMessage = "Nome do Ator é Obrigatório!")]
        public string Nome { get; set; }
    }
}
