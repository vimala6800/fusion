using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SalesFlow.Migrations
{
    /// <inheritdoc />
    public partial class requisitionfiles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Requistionfiles",
                table: "Requistionfiles");

            migrationBuilder.RenameTable(
                name: "Requistionfiles",
                newName: "RequisitionFiles");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RequisitionFiles",
                table: "RequisitionFiles",
                column: "RequsitionFileID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_RequisitionFiles",
                table: "RequisitionFiles");

            migrationBuilder.RenameTable(
                name: "RequisitionFiles",
                newName: "Requistionfiles");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Requistionfiles",
                table: "Requistionfiles",
                column: "RequsitionFileID");
        }
    }
}
