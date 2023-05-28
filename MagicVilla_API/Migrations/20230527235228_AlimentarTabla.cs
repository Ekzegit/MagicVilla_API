﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MagicVillaAPI.Migrations
{
    /// <inheritdoc />
    public partial class AlimentarTabla : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Villas",
                columns: new[] { "Id", "Amenidad", "Detalle", "FechaActualizacion", "FechaCreacion", "ImagenUrl", "MetrosCuadrados", "Nombre", "Ocupantes", "Tarifa" },
                values: new object[,]
                {
                    { 1, "", "Detalle de la villaa...", new DateTime(2023, 5, 27, 19, 52, 28, 755, DateTimeKind.Local).AddTicks(9082), new DateTime(2023, 5, 27, 19, 52, 28, 755, DateTimeKind.Local).AddTicks(8970), "", 50, "Villa Real", 5, 200.0 },
                    { 2, "", "Detalle de la villaa...", new DateTime(2023, 5, 27, 19, 52, 28, 755, DateTimeKind.Local).AddTicks(9089), new DateTime(2023, 5, 27, 19, 52, 28, 755, DateTimeKind.Local).AddTicks(9087), "", 30, "Villa Santos", 3, 100.0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
