using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CleanArchMVC.Infra.Data.Migrations
{
    public partial class SeedProducts : Migration
    {
        protected override void Up(MigrationBuilder mb)
        {
            mb.Sql("INSERT INTO Products(Name,Description,Price,Stock,Image,CategoryId) " +
            "VALUES('Spiral Notebook','Spiral Notebook 100 Sheets',7.45,50,'notebook1.jpg',1)");

            mb.Sql("INSERT INTO Products(Name,Description,Price,Stock,Image,CategoryId) " +
            "VALUES('School Case','Gray School Case',5.65,70,'Case1.jpg',1)");

            mb.Sql("INSERT INTO Products(Name,Description,Price,Stock,Image,CategoryId) " +
            "VALUES('School Eraser','Small School Eraser',3.25,80,'eraser.jpg',1)");

            mb.Sql("INSERT INTO Products(Name,Description,Price,Stock,Image,CategoryId) " +
            "VALUES('School Calculator','Simple Calculator ',15.39,20,'calculator1.jpg',2)");
        }

        protected override void Down(MigrationBuilder mb)
        {
            mb.Sql("DELETE FROM Products");
        }
    }
}
