using GamesService.Models;

namespace GamesService.Data
{
    public static class PrepDb
    {
        public static void PrepPopulation(IApplicationBuilder app)
        {
            using(var serviceScope = app.ApplicationServices.CreateScope())
            {
                SeedData(serviceScope.ServiceProvider.GetService<AppDbContext>());
            }
        }

        private static void SeedData(AppDbContext context)
        {
            if(!context.Games.Any())
            {  
                System.Console.WriteLine("--> Seeding data...");

                context.Games.AddRange(
                    new Game() { Name="Tomb Raider", Type="Explorer" },
                    new Game() { Name="Red Alert", Type= "Strategy" },
                    new Game() { Name="World of Tanks", Type="Combat" }
                );

                context.SaveChanges();
            } else {
                System.Console.WriteLine("--> We already have data");
            }
        }
    }
}