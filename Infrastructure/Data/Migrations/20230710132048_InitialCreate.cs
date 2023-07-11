using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint(20)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    nombre = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    email = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    email_validate_at = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    estado = table.Column<sbyte>(type: "tinyint(4)", nullable: false),
                    created_by = table.Column<sbyte>(type: "tinyint(4)", nullable: false),
                    updated_by = table.Column<long>(type: "bigint(20)", nullable: false),
                    foto = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    password = table.Column<string>(type: "varchar(60)", maxLength: 60, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    created_at = table.Column<DateTime>(type: "timestamp", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp", nullable: false),
                    deleted_at = table.Column<DateTime>(type: "timestamp", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Bodegas",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint(20)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Id_responsable = table.Column<long>(type: "bigint(20)", nullable: false),
                    Estado = table.Column<sbyte>(type: "tinyint(4)", nullable: false),
                    Created_by = table.Column<long>(type: "bigint(20)", nullable: false),
                    update_by = table.Column<long>(type: "bigint(20)", nullable: false),
                    Created_at = table.Column<DateTime>(type: "timestamp", nullable: false),
                    update_at = table.Column<DateTime>(type: "timestamp", nullable: false),
                    Deleted_at = table.Column<DateTime>(type: "timestamp", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bodegas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Bodegas_Users_Created_by",
                        column: x => x.Created_by,
                        principalTable: "Users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Bodegas_Users_Id_responsable",
                        column: x => x.Id_responsable,
                        principalTable: "Users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Bodegas_Users_update_by",
                        column: x => x.update_by,
                        principalTable: "Users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Productos",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint(20)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    nombre = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    descripcion = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Estado = table.Column<sbyte>(type: "tinyint(4)", nullable: false),
                    created_by = table.Column<long>(type: "bigint(20)", nullable: false),
                    updated_by = table.Column<long>(type: "bigint(20)", nullable: false),
                    Created_at = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Updated_at = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    deleted_at = table.Column<DateTime>(type: "timestamp", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Productos", x => x.id);
                    table.ForeignKey(
                        name: "FK_Productos_Users_created_by",
                        column: x => x.created_by,
                        principalTable: "Users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Productos_Users_updated_by",
                        column: x => x.updated_by,
                        principalTable: "Users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Inventarios",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint(20)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    id_bodega = table.Column<long>(type: "bigint(20)", nullable: false),
                    id_producto = table.Column<long>(type: "bigint(20)", nullable: false),
                    cantidad = table.Column<int>(type: "int(20)", nullable: false),
                    created_by = table.Column<long>(type: "bigint(20)", nullable: false),
                    updated_by = table.Column<long>(type: "bigint(20)", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp", nullable: false),
                    deleted_at = table.Column<DateTime>(type: "timestamp", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inventarios", x => x.id);
                    table.ForeignKey(
                        name: "FK_Inventarios_Bodegas_id_bodega",
                        column: x => x.id_bodega,
                        principalTable: "Bodegas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Inventarios_Productos_id_producto",
                        column: x => x.id_producto,
                        principalTable: "Productos",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Inventarios_Users_created_by",
                        column: x => x.created_by,
                        principalTable: "Users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Inventarios_Users_updated_by",
                        column: x => x.updated_by,
                        principalTable: "Users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Historial",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint(20)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Cantidad = table.Column<int>(type: "int(20)", nullable: false),
                    id_bodega_origen = table.Column<long>(type: "bigint(20)", nullable: false),
                    id_bodega_destino = table.Column<long>(type: "bigint(20)", nullable: false),
                    id_inventario = table.Column<long>(type: "bigint(20)", nullable: false),
                    created_by = table.Column<long>(type: "bigint(20)", nullable: false),
                    updated_by = table.Column<long>(type: "bigint(20)", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp", nullable: false),
                    deleted_at = table.Column<DateTime>(type: "timestamp", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Historial", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Historial_Bodegas_id_bodega_destino",
                        column: x => x.id_bodega_destino,
                        principalTable: "Bodegas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Historial_Bodegas_id_bodega_origen",
                        column: x => x.id_bodega_origen,
                        principalTable: "Bodegas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Historial_Inventarios_id_inventario",
                        column: x => x.id_inventario,
                        principalTable: "Inventarios",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Historial_Users_created_by",
                        column: x => x.created_by,
                        principalTable: "Users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Historial_Users_updated_by",
                        column: x => x.updated_by,
                        principalTable: "Users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Bodegas_Created_by",
                table: "Bodegas",
                column: "Created_by");

            migrationBuilder.CreateIndex(
                name: "IX_Bodegas_Id_responsable",
                table: "Bodegas",
                column: "Id_responsable");

            migrationBuilder.CreateIndex(
                name: "IX_Bodegas_update_by",
                table: "Bodegas",
                column: "update_by");

            migrationBuilder.CreateIndex(
                name: "IX_Historial_created_by",
                table: "Historial",
                column: "created_by");

            migrationBuilder.CreateIndex(
                name: "IX_Historial_id_bodega_destino",
                table: "Historial",
                column: "id_bodega_destino");

            migrationBuilder.CreateIndex(
                name: "IX_Historial_id_bodega_origen",
                table: "Historial",
                column: "id_bodega_origen");

            migrationBuilder.CreateIndex(
                name: "IX_Historial_id_inventario",
                table: "Historial",
                column: "id_inventario");

            migrationBuilder.CreateIndex(
                name: "IX_Historial_updated_by",
                table: "Historial",
                column: "updated_by");

            migrationBuilder.CreateIndex(
                name: "IX_Inventarios_created_by",
                table: "Inventarios",
                column: "created_by");

            migrationBuilder.CreateIndex(
                name: "IX_Inventarios_id_bodega",
                table: "Inventarios",
                column: "id_bodega");

            migrationBuilder.CreateIndex(
                name: "IX_Inventarios_id_producto",
                table: "Inventarios",
                column: "id_producto");

            migrationBuilder.CreateIndex(
                name: "IX_Inventarios_updated_by",
                table: "Inventarios",
                column: "updated_by");

            migrationBuilder.CreateIndex(
                name: "IX_Productos_created_by",
                table: "Productos",
                column: "created_by");

            migrationBuilder.CreateIndex(
                name: "IX_Productos_updated_by",
                table: "Productos",
                column: "updated_by");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Historial");

            migrationBuilder.DropTable(
                name: "Inventarios");

            migrationBuilder.DropTable(
                name: "Bodegas");

            migrationBuilder.DropTable(
                name: "Productos");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
