using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace service.Migrations
{
    public partial class DateTimeInTransactionItem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "time",
                table: "TransactionItems",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "time",
                table: "TransactionItems");
        }
    }
}
