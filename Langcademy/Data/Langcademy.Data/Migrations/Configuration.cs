namespace Langcademy.Data.Migrations
{
    using Models;
    using System.Data.Entity.Migrations;

    public sealed class Configuration : DbMigrationsConfiguration<Langcademy.Data.ApplicationDbContext>
    {
        public Configuration()
        {
            this.AutomaticMigrationsEnabled = true;
            this.AutomaticMigrationDataLossAllowed = true;
           // ContextKey = "Langcademy.Data.ApplicationDbContext";
        }

        protected override void Seed(Langcademy.Data.ApplicationDbContext context)
        {


            context.Topics.Add(new Topic
            {
                Id = 3,
                Name = "fosjndfgskgn",
                WordsToTranslate ={
                new WordToTranslate
                {
                    Id=2,
                    Text="fpskngs",
                    Translation="daognaofd",
                    TopicId=3

                }
            }
            });
        }
    }
}
