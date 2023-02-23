using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BankSystem.Data.Migrations
{
    /// <inheritdoc />
    public partial class mig_add_updateEntity_newProperty_CartApplication : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CartId",
                table: "CartApplications",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_CartApplications_CartId",
                table: "CartApplications",
                column: "CartId");

            migrationBuilder.AddForeignKey(
                name: "FK_CartApplications_Carts_CartId",
                table: "CartApplications",
                column: "CartId",
                principalTable: "Carts",
                principalColumn: "CartId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CartApplications_Carts_CartId",
                table: "CartApplications");

            migrationBuilder.DropIndex(
                name: "IX_CartApplications_CartId",
                table: "CartApplications");

            migrationBuilder.DropColumn(
                name: "CartId",
                table: "CartApplications");
        }
    }
}
