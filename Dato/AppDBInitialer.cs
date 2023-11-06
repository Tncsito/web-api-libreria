using Libreria_EESA.Dato.Modelo;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace Libreria_EESA.Dato
{
    public class AppDBInitialer
    {
        //Metodo que agrega datos a nuestra DB
        public static void Seed(IApplicationBuilder applicationbuilder)
        {
            using (var serviceScope = applicationbuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDBContext>();

                if(!context.Books.Any())
                {
                    context.Books.AddRange(new Book()
                    {
                        Titulo = "1st Book Title",
                        Descripcion = "1st Book Descripcion",
                        IsRead = true,
                        DateRead = DateTime.Now.AddDays(-10),
                        Rate = 4,
                        Genero = "Macho",
                        Autor = "1st Author",
                        CoverUrl = "Https..",
                        Date = DateTime.Now,
                    },
                    new Book()
                    {
                        Titulo = "2nd Book Title",
                        Descripcion = "2nd Book Descripcion",
                        IsRead = true,
                        Genero = "Macho",
                        Autor = "2nd Author",
                        CoverUrl = "Https..",
                        Date = DateTime.Now,
                    });
                    context.SaveChanges();
                }
            }
        }
    }
}
