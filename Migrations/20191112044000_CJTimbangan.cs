using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CJTimbangan.Migrations
{
    public partial class CJTimbangan : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "m_code",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    code = table.Column<string>(nullable: true),
                    id_controller = table.Column<string>(nullable: true),
                    type_controller = table.Column<string>(nullable: true),
                    ip_controller = table.Column<string>(nullable: true),
                    barang = table.Column<string>(nullable: true),
                    lot_no = table.Column<string>(nullable: true),
                    counter = table.Column<int>(nullable: false),
                    tare = table.Column<double>(nullable: false),
                    kemasan = table.Column<string>(nullable: true),
                    location = table.Column<string>(nullable: true),
                    id_printer = table.Column<string>(nullable: true),
                    type_printer = table.Column<string>(nullable: true),
                    ip_printer = table.Column<string>(nullable: true),
                    path = table.Column<string>(nullable: true),
                    id_dig_scale = table.Column<string>(nullable: true),
                    type_dig_scale = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_m_code", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "m_hasil",
                columns: table => new
                {
                    id_transaksi = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    id_controller = table.Column<string>(nullable: true),
                    type_controller = table.Column<string>(nullable: true),
                    id_printer = table.Column<string>(nullable: true),
                    type_printer = table.Column<string>(nullable: true),
                    id_dig_scale = table.Column<string>(nullable: true),
                    type_dig_scale = table.Column<string>(nullable: true),
                    lot_no = table.Column<string>(nullable: true),
                    barang = table.Column<string>(nullable: true),
                    counter = table.Column<int>(nullable: false),
                    tare = table.Column<float>(nullable: false),
                    kemasan = table.Column<string>(nullable: true),
                    tgl_cetak = table.Column<DateTime>(nullable: false),
                    tgl_produksi = table.Column<DateTime>(nullable: false),
                    weight = table.Column<float>(nullable: false),
                    location = table.Column<string>(nullable: true),
                    status = table.Column<string>(nullable: true),
                    reprint = table.Column<int>(nullable: false),
                    shift = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_m_hasil", x => x.id_transaksi);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "m_code");

            migrationBuilder.DropTable(
                name: "m_hasil");
        }
    }
}
