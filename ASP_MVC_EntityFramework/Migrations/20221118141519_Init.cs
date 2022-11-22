using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ASP_MVC_EntityFramework.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "People",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_People", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "City", "Name", "PhoneNumber" },
                values: new object[,]
                {
                    { 1, "Gothenburg", "Kalle Person", "555-5555" },
                    { 2, "Gothenburg", "Stina Bratt", "555-5555" },
                    { 3, "Paris", "Jennie Antonsson", "444-4444" },
                    { 4, "London", "Sven Karlsson", "888-8888" },
                    { 5, "Stockholm", "Katarina Fors", "999-9999" },
                    { 6, "Warsaw", "Wendely Blom", "222-2222" },
                    { 7, "Munich", "Hugo Magnusson", "444-2222" },
                    { 8, "Bangkok", "Alice Olsson", "111-1111" },
                    { 9, "Vladivostok", "Belly Button", "000-4444" },
                    { 10, "Buenos Aires", "Tom Andersson", "999-7777" },
                    { 11, "Hanoi", "Alma Starstruck", "888-4444" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "People");
        }
    }
}
