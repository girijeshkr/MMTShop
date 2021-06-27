using Microsoft.EntityFrameworkCore.Migrations;

namespace MMTShop.Migrations
{
    public partial class spGetProductsByCategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var sp = @"CREATE PROCEDURE [dbo].[GetProductsByCategory]
                    @Category varchar(20)
                AS
                BEGIN
                    SET NOCOUNT ON;
                    select * from [dbo].[Products] where Category = @Category
                END";

            migrationBuilder.Sql(sp);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
