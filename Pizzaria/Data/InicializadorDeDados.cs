using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Pizzaria.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pizzaria.Data
{
    public class InicializadorDeDados
    {
        public static void Inicializar(IApplicationBuilder builder)
        {
            using (var serviceScope = builder.ApplicationServices.CreateScope())
            {
                var context = serviceScope
                    .ServiceProvider
                    .GetService<PizzariaDbContext>();

                context.Database.EnsureCreated();

                if (!context.Pizzas.Any())
                {
                    context.Pizzas.AddRange(new List<Pizza>()
                    { 
                        new Pizza("https://www.anamariabrogui.com.br/assets/uploads/receitas/fotos/usuario-1932-5a1b7911dfda6e3c351c30de564da267.jpg", "Pizza Mussarela", 20, 2),
                        new Pizza("https://www.sabornamesa.com.br/media/k2/items/cache/513d7a0ab11e38f7bd117d760146fed3_L.jpg", "Pizza Calabresa", 18, 3)
                    });
                }

                if (!context.Sabores.Any())
                {
                    context.Sabores.AddRange(new List<Sabor>()
                    { 
                        new Sabor("https://s2.glbimg.com/RlMNwXYV8qKALf5ocE0XlIuhFl0=/696x390/smart/filters:cover():strip_icc()/i.s3.glbimg.com/v1/AUTH_e84042ef78cb4708aeebdf1c68c6cbd6/internal_photos/bs/2020/u/0/z1DHT9Qc6H126dlOBBDw/calabresa-acebolada.jpg", "Calabresa"),
                        new Sabor("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQGDi4MERGMlsEgYBEdulg1cMqx5zjUf_AX6g&usqp=CAU", "Mussarela")
                    });
                }

                if (!context.Tamanhos.Any())
                {
                    context.Tamanhos.AddRange(new List<Tamanho>()
                    {
                        new Tamanho("Pequeno"),
                        new Tamanho("Médio"),
                        new Tamanho("Grande")
                    });
                }

                if (!context.PizzasSabores.Any())
                {
                    context.PizzasSabores.AddRange(new List<PizzaSabor>()
                    {
                        new PizzaSabor(1, 2),
                        new PizzaSabor(2, 1)
                    });
                }
            }
        }
    }
}
