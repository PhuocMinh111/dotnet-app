
namespace dotnet_app.Models
{
    public class Seed
    {
        private readonly ILogger _logger;
        public Seed (ILogger<Seed> logger)
        {
            _logger = logger;
        }
        

        public static async Task SeedData(DataContext context)
        {
            if (context.Db.Any()) return;

            var Activities = new List<Todos> {
                new Todos 
                {
                    Id = 1,
                    title = "todo1",
                    contents = "content1",
                    date = DateTime.UtcNow.AddMonths(-2),

                },
                new Todos 
                {
                    Id = 2,
                    title = "todo2",
                    contents = "content2",
                    date = DateTime.UtcNow.AddMonths(-2),

                },
                new Todos 
                {
                    Id = 3,
                    title = "todo3",
                    contents = "content3",
                    date = DateTime.UtcNow.AddMonths(-3),

                },
                new Todos 
                {
                    Id = 4,
                    title = "todo4",
                    contents = "content4",
                    date = DateTime.UtcNow.AddMonths(-5),

                },
                new Todos 
                {
                    Id = 5,
                    title = "todo1",
                    contents = "content1",
                    date = DateTime.UtcNow.AddMonths(-6),

                },
                
            };
            
            await context.Db.AddRangeAsync(Activities);
            
            await context.SaveChangesAsync();
        }
    }
}