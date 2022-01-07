using System.Collections.Generic;
using System.Linq;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MovieApp.Data;

namespace MovieAp
{
    public static class DataSeeder
    {
        public static void Seed(this IHost host)
        {
            using var scope = host.Services.CreateScope();
            using var context = scope.ServiceProvider.GetRequiredService<MovieDataContext>();
            context.Database.EnsureCreated();
            AddMovies(context);
        }

        private static void AddMovies(MovieDataContext context)
        {
            var movie = context.Movies.FirstOrDefault();
            if (movie != null) return;

            context.Movies.Add(new Movie()
            {
                Title = "The Priest",
                Year = 2008,
                Summary = "The priest Jumbled a couple of Vampires and Nutted the Vmpire Nest",
                Actors = new List<Actors>
                {
                    new Actors{FullName = "Okello Daniel"},
                    new Actors{FullName = "Daniel Maneno"}
                }
            });
            
            context.Movies.Add(new Movie()
            {
                Title = "The Messiah",
                Year = 2014,
                Summary = "The priest Jumbled a couple of Vampires and Nutted the Vmpire Nest",
                Actors = new List<Actors>
                {
                    new Actors{FullName = "Okello Daniel"},
                    new Actors{FullName = "Daniel Maneno"}
                }
            });
            
            context.Movies.Add(new Movie()
            {
                Title = "The Papa",
                Year = 2044,
                Summary = "The priest Jumbled a couple of Vampires and Nutted the Vmpire Nest",
                Actors = new List<Actors>
                {
                    new Actors{FullName = "Okello Daniel"},
                    new Actors{FullName = "Daniel Maneno"}
                }
            });

            context.SaveChanges();
        }
    }
}