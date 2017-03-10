namespace Langcademy.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TranslationPropertyAdded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.WordToTranslates", "Translation", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.WordToTranslates", "Translation");
        }
    }
}
