using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HospitalAutomation.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Doctors_Policlinics_PoliclinicId",
                table: "Doctors");

            migrationBuilder.DropForeignKey(
                name: "FK_Protocols_Policlinics_PoliclinicId",
                table: "Protocols");

            migrationBuilder.DropTable(
                name: "Policlinics");

            migrationBuilder.DropIndex(
                name: "IX_Protocols_PoliclinicId",
                table: "Protocols");

            migrationBuilder.DropIndex(
                name: "IX_Doctors_PoliclinicId",
                table: "Doctors");

            migrationBuilder.DropColumn(
                name: "PoliclinicId",
                table: "Protocols");

            migrationBuilder.DropColumn(
                name: "PoliclinicId",
                table: "Doctors");

            migrationBuilder.AlterColumn<string>(
                name: "Image",
                table: "Patients",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AddColumn<DateOnly>(
                name: "BirthDate",
                table: "Doctors",
                type: "date",
                nullable: false,
                defaultValue: new DateOnly(1, 1, 1));

            migrationBuilder.AddColumn<int>(
                name: "BloodGroupType",
                table: "Doctors",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "GenderType",
                table: "Doctors",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<long>(
                name: "IdentificationNumber",
                table: "Doctors",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Doctors",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "PoliclinicType",
                table: "Doctors",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BirthDate",
                table: "Doctors");

            migrationBuilder.DropColumn(
                name: "BloodGroupType",
                table: "Doctors");

            migrationBuilder.DropColumn(
                name: "GenderType",
                table: "Doctors");

            migrationBuilder.DropColumn(
                name: "IdentificationNumber",
                table: "Doctors");

            migrationBuilder.DropColumn(
                name: "Image",
                table: "Doctors");

            migrationBuilder.DropColumn(
                name: "PoliclinicType",
                table: "Doctors");

            migrationBuilder.AddColumn<Guid>(
                name: "PoliclinicId",
                table: "Protocols",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AlterColumn<string>(
                name: "Image",
                table: "Patients",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AddColumn<Guid>(
                name: "PoliclinicId",
                table: "Doctors",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "Policlinics",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Policlinics", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Protocols_PoliclinicId",
                table: "Protocols",
                column: "PoliclinicId");

            migrationBuilder.CreateIndex(
                name: "IX_Doctors_PoliclinicId",
                table: "Doctors",
                column: "PoliclinicId");

            migrationBuilder.AddForeignKey(
                name: "FK_Doctors_Policlinics_PoliclinicId",
                table: "Doctors",
                column: "PoliclinicId",
                principalTable: "Policlinics",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Protocols_Policlinics_PoliclinicId",
                table: "Protocols",
                column: "PoliclinicId",
                principalTable: "Policlinics",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
