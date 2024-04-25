using Microsoft.EntityFrameworkCore.Migrations;

namespace HotelProject.DataAccessLayer.Migrations
{
	public partial class mig_fix_workLocationTypo : Migration
	{
		protected override void Up(MigrationBuilder migrationBuilder)
		{
			//migrationBuilder.DropForeignKey(
			//    name: "FK_AspNetUsers_WorkLocatıons_WorkLocationID",
			//    table: "AspNetUsers");

			//migrationBuilder.DropPrimaryKey(
			//    name: "PK_WorkLocatıons",
			//    table: "WorkLocatıons");

			//migrationBuilder.RenameTable(
			//    name: "WorkLocatıons",
			//    newName: "WorkLocations");


			migrationBuilder.CreateTable(
					name: "WorkLocations",
					columns: table => new
					{
						WorkLocationID = table.Column<int>(type: "int", nullable: false)
									.Annotation("SqlServer:Identity", "1, 1"),
						WorkLocationName = table.Column<string>(type: "nvarchar(max)", nullable: false),
						WorkLocationCity = table.Column<string>(type: "nvarchar(max)", nullable: false)
					},
					constraints: table =>
					{
						table.PrimaryKey("PK_WorkLocations", x => x.WorkLocationID);
					});

			//migrationBuilder.CreateIndex(
			//		name: "IX_AspNetUsers_WorkLocationID",
			//		table: "AspNetUsers",
			//		column: "WorkLocationID");

			migrationBuilder.AddForeignKey(
					name: "FK_AspNetUsers_WorkLocations_WorkLocationID",
								table: "AspNetUsers",
								column: "WorkLocationID",
								principalTable: "WorkLocations",
								principalColumn: "WorkLocationID",
								onDelete: ReferentialAction.Cascade);

			//migrationBuilder.AddPrimaryKey(
			//             name: "PK_WorkLocations",
			//             table: "WorkLocations",
			//             column: "WorkLocationID");

			//         migrationBuilder.AddForeignKey(
			//             name: "FK_AspNetUsers_WorkLocations_WorkLocationID",
			//             table: "AspNetUsers",
			//             column: "WorkLocationID",
			//             principalTable: "WorkLocations",
			//             principalColumn: "WorkLocationID",
			//             onDelete: ReferentialAction.Cascade);
			//     }
		}

		protected override void Down(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.DropForeignKey(
							name: "FK_AspNetUsers_WorkLocations_WorkLocationID",
							table: "AspNetUsers");

			migrationBuilder.DropTable(
					name: "WorkLocations");

			migrationBuilder.DropIndex(
					name: "IX_AspNetUsers_WorkLocationID",
					table: "AspNetUsers");

			migrationBuilder.DropColumn(
					name: "WorkDepartment",
					table: "AspNetUsers");

			migrationBuilder.DropColumn(
					name: "WorkLocationID",
					table: "AspNetUsers");

			//migrationBuilder.DropForeignKey(
			//    name: "FK_AspNetUsers_WorkLocations_WorkLocationID",
			//    table: "AspNetUsers");

			//migrationBuilder.DropPrimaryKey(
			//    name: "PK_WorkLocations",
			//    table: "WorkLocations");

			//migrationBuilder.RenameTable(
			//    name: "WorkLocations",
			//    newName: "WorkLocatıons");

			//migrationBuilder.AddPrimaryKey(
			//    name: "PK_WorkLocatıons",
			//    table: "WorkLocatıons",
			//    column: "WorkLocationID");

			//migrationBuilder.AddForeignKey(
			//    name: "FK_AspNetUsers_WorkLocatıons_WorkLocationID",
			//    table: "AspNetUsers",
			//    column: "WorkLocationID",
			//    principalTable: "WorkLocatıons",
			//    principalColumn: "WorkLocationID",
			//    onDelete: ReferentialAction.Cascade);
		}
	}
}
