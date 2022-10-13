using Microsoft.EntityFrameworkCore.Migrations;

namespace Client.Migrations
{
    public partial class hh : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK__pengadaan__idBar__3C69FB99",
                table: "pengadaan");

            migrationBuilder.DropForeignKey(
                name: "FK__pengadaan__idDiv__3B75D760",
                table: "pengadaan");

            migrationBuilder.DropForeignKey(
                name: "FK__pengadaan__idSta__3E52440B",
                table: "pengadaan");

            migrationBuilder.DropForeignKey(
                name: "FK__pengadaan__idSup__3D5E1FD2",
                table: "pengadaan");

            migrationBuilder.DropForeignKey(
                name: "FK__Product__idSatua__37A5467C",
                table: "Product");

            migrationBuilder.DropForeignKey(
                name: "FK__Product__idSuppl__38996AB5",
                table: "Product");

            migrationBuilder.DropPrimaryKey(
                name: "PK_supplier",
                table: "supplier");

            migrationBuilder.DropPrimaryKey(
                name: "PK_status",
                table: "status");

            migrationBuilder.DropPrimaryKey(
                name: "PK_satuan",
                table: "satuan");

            migrationBuilder.DropPrimaryKey(
                name: "PK_role",
                table: "role");

            migrationBuilder.DropPrimaryKey(
                name: "PK_pengadaan",
                table: "pengadaan");

            migrationBuilder.DropPrimaryKey(
                name: "PK_divisi",
                table: "divisi");

            migrationBuilder.DropColumn(
                name: "pengaadan_GUID",
                table: "pengadaan");

            migrationBuilder.RenameTable(
                name: "supplier",
                newName: "Supplier");

            migrationBuilder.RenameTable(
                name: "status",
                newName: "Status");

            migrationBuilder.RenameTable(
                name: "satuan",
                newName: "Satuan");

            migrationBuilder.RenameTable(
                name: "role",
                newName: "Role");

            migrationBuilder.RenameTable(
                name: "pengadaan",
                newName: "Pengadaan");

            migrationBuilder.RenameTable(
                name: "divisi",
                newName: "Divisi");

            migrationBuilder.RenameColumn(
                name: "nama",
                table: "Supplier",
                newName: "Nama");

            migrationBuilder.RenameColumn(
                name: "kota",
                table: "Supplier",
                newName: "Kota");

            migrationBuilder.RenameColumn(
                name: "alamat",
                table: "Supplier",
                newName: "Alamat");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Supplier",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Status",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Status",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "nama",
                table: "Satuan",
                newName: "Nama");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Satuan",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Role",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Role",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "stockProduct",
                table: "Product",
                newName: "StockProduct");

            migrationBuilder.RenameColumn(
                name: "namaProduk",
                table: "Product",
                newName: "NamaProduk");

            migrationBuilder.RenameColumn(
                name: "idSupplier",
                table: "Product",
                newName: "IdSupplier");

            migrationBuilder.RenameColumn(
                name: "idSatuan",
                table: "Product",
                newName: "IdSatuan");

            migrationBuilder.RenameColumn(
                name: "hargaProduct",
                table: "Product",
                newName: "HargaProduct");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Product",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_Product_idSupplier",
                table: "Product",
                newName: "IX_Product_IdSupplier");

            migrationBuilder.RenameIndex(
                name: "IX_Product_idSatuan",
                table: "Product",
                newName: "IX_Product_IdSatuan");

            migrationBuilder.RenameColumn(
                name: "totals",
                table: "Pengadaan",
                newName: "Totals");

            migrationBuilder.RenameColumn(
                name: "kuantitas",
                table: "Pengadaan",
                newName: "Kuantitas");

            migrationBuilder.RenameColumn(
                name: "idSupplier",
                table: "Pengadaan",
                newName: "IdSupplier");

            migrationBuilder.RenameColumn(
                name: "idStatus",
                table: "Pengadaan",
                newName: "IdStatus");

            migrationBuilder.RenameColumn(
                name: "idDivisi",
                table: "Pengadaan",
                newName: "IdDivisi");

            migrationBuilder.RenameColumn(
                name: "idBarang",
                table: "Pengadaan",
                newName: "IdBarang");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Pengadaan",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_pengadaan_idSupplier",
                table: "Pengadaan",
                newName: "IX_Pengadaan_IdSupplier");

            migrationBuilder.RenameIndex(
                name: "IX_pengadaan_idStatus",
                table: "Pengadaan",
                newName: "IX_Pengadaan_IdStatus");

            migrationBuilder.RenameIndex(
                name: "IX_pengadaan_idDivisi",
                table: "Pengadaan",
                newName: "IX_Pengadaan_IdDivisi");

            migrationBuilder.RenameIndex(
                name: "IX_pengadaan_idBarang",
                table: "Pengadaan",
                newName: "IX_Pengadaan_IdBarang");

            migrationBuilder.RenameColumn(
                name: "nama",
                table: "Divisi",
                newName: "Nama");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Divisi",
                newName: "Id");

            migrationBuilder.AlterColumn<string>(
                name: "Nama",
                table: "Supplier",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldUnicode: false,
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Kota",
                table: "Supplier",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldUnicode: false,
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Alamat",
                table: "Supplier",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldUnicode: false,
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Status",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(20)",
                oldUnicode: false,
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Nama",
                table: "Satuan",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(20)",
                oldUnicode: false,
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Role",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(20)",
                oldUnicode: false,
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NamaProduk",
                table: "Product",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldUnicode: false,
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Nama",
                table: "Divisi",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(20)",
                oldUnicode: false,
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Supplier",
                table: "Supplier",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Status",
                table: "Status",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Satuan",
                table: "Satuan",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Role",
                table: "Role",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Pengadaan",
                table: "Pengadaan",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Divisi",
                table: "Divisi",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Pengadaan_Product_IdBarang",
                table: "Pengadaan",
                column: "IdBarang",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Pengadaan_Divisi_IdDivisi",
                table: "Pengadaan",
                column: "IdDivisi",
                principalTable: "Divisi",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Pengadaan_Supplier_IdStatus",
                table: "Pengadaan",
                column: "IdStatus",
                principalTable: "Supplier",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Pengadaan_Status_IdSupplier",
                table: "Pengadaan",
                column: "IdSupplier",
                principalTable: "Status",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Satuan_IdSatuan",
                table: "Product",
                column: "IdSatuan",
                principalTable: "Satuan",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Supplier_IdSupplier",
                table: "Product",
                column: "IdSupplier",
                principalTable: "Supplier",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pengadaan_Product_IdBarang",
                table: "Pengadaan");

            migrationBuilder.DropForeignKey(
                name: "FK_Pengadaan_Divisi_IdDivisi",
                table: "Pengadaan");

            migrationBuilder.DropForeignKey(
                name: "FK_Pengadaan_Supplier_IdStatus",
                table: "Pengadaan");

            migrationBuilder.DropForeignKey(
                name: "FK_Pengadaan_Status_IdSupplier",
                table: "Pengadaan");

            migrationBuilder.DropForeignKey(
                name: "FK_Product_Satuan_IdSatuan",
                table: "Product");

            migrationBuilder.DropForeignKey(
                name: "FK_Product_Supplier_IdSupplier",
                table: "Product");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Supplier",
                table: "Supplier");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Status",
                table: "Status");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Satuan",
                table: "Satuan");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Role",
                table: "Role");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Pengadaan",
                table: "Pengadaan");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Divisi",
                table: "Divisi");

            migrationBuilder.RenameTable(
                name: "Supplier",
                newName: "supplier");

            migrationBuilder.RenameTable(
                name: "Status",
                newName: "status");

            migrationBuilder.RenameTable(
                name: "Satuan",
                newName: "satuan");

            migrationBuilder.RenameTable(
                name: "Role",
                newName: "role");

            migrationBuilder.RenameTable(
                name: "Pengadaan",
                newName: "pengadaan");

            migrationBuilder.RenameTable(
                name: "Divisi",
                newName: "divisi");

            migrationBuilder.RenameColumn(
                name: "Nama",
                table: "supplier",
                newName: "nama");

            migrationBuilder.RenameColumn(
                name: "Kota",
                table: "supplier",
                newName: "kota");

            migrationBuilder.RenameColumn(
                name: "Alamat",
                table: "supplier",
                newName: "alamat");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "supplier",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "status",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "status",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Nama",
                table: "satuan",
                newName: "nama");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "satuan",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "role",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "role",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "StockProduct",
                table: "Product",
                newName: "stockProduct");

            migrationBuilder.RenameColumn(
                name: "NamaProduk",
                table: "Product",
                newName: "namaProduk");

            migrationBuilder.RenameColumn(
                name: "IdSupplier",
                table: "Product",
                newName: "idSupplier");

            migrationBuilder.RenameColumn(
                name: "IdSatuan",
                table: "Product",
                newName: "idSatuan");

            migrationBuilder.RenameColumn(
                name: "HargaProduct",
                table: "Product",
                newName: "hargaProduct");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Product",
                newName: "id");

            migrationBuilder.RenameIndex(
                name: "IX_Product_IdSupplier",
                table: "Product",
                newName: "IX_Product_idSupplier");

            migrationBuilder.RenameIndex(
                name: "IX_Product_IdSatuan",
                table: "Product",
                newName: "IX_Product_idSatuan");

            migrationBuilder.RenameColumn(
                name: "Totals",
                table: "pengadaan",
                newName: "totals");

            migrationBuilder.RenameColumn(
                name: "Kuantitas",
                table: "pengadaan",
                newName: "kuantitas");

            migrationBuilder.RenameColumn(
                name: "IdSupplier",
                table: "pengadaan",
                newName: "idSupplier");

            migrationBuilder.RenameColumn(
                name: "IdStatus",
                table: "pengadaan",
                newName: "idStatus");

            migrationBuilder.RenameColumn(
                name: "IdDivisi",
                table: "pengadaan",
                newName: "idDivisi");

            migrationBuilder.RenameColumn(
                name: "IdBarang",
                table: "pengadaan",
                newName: "idBarang");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "pengadaan",
                newName: "id");

            migrationBuilder.RenameIndex(
                name: "IX_Pengadaan_IdSupplier",
                table: "pengadaan",
                newName: "IX_pengadaan_idSupplier");

            migrationBuilder.RenameIndex(
                name: "IX_Pengadaan_IdStatus",
                table: "pengadaan",
                newName: "IX_pengadaan_idStatus");

            migrationBuilder.RenameIndex(
                name: "IX_Pengadaan_IdDivisi",
                table: "pengadaan",
                newName: "IX_pengadaan_idDivisi");

            migrationBuilder.RenameIndex(
                name: "IX_Pengadaan_IdBarang",
                table: "pengadaan",
                newName: "IX_pengadaan_idBarang");

            migrationBuilder.RenameColumn(
                name: "Nama",
                table: "divisi",
                newName: "nama");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "divisi",
                newName: "id");

            migrationBuilder.AlterColumn<string>(
                name: "nama",
                table: "supplier",
                type: "varchar(100)",
                unicode: false,
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "kota",
                table: "supplier",
                type: "varchar(100)",
                unicode: false,
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "alamat",
                table: "supplier",
                type: "varchar(100)",
                unicode: false,
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "name",
                table: "status",
                type: "varchar(20)",
                unicode: false,
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "nama",
                table: "satuan",
                type: "varchar(20)",
                unicode: false,
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "name",
                table: "role",
                type: "varchar(20)",
                unicode: false,
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "namaProduk",
                table: "Product",
                type: "varchar(100)",
                unicode: false,
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "nama",
                table: "divisi",
                type: "varchar(20)",
                unicode: false,
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "pengaadan_GUID",
                table: "pengadaan",
                type: "varchar(9)",
                unicode: false,
                maxLength: 9,
                nullable: true,
                computedColumnSql: "('SPB-'+right(replicate('0',(8))+CONVERT([varchar],[id]),(5)))");

            migrationBuilder.AddPrimaryKey(
                name: "PK_supplier",
                table: "supplier",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_status",
                table: "status",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_satuan",
                table: "satuan",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_role",
                table: "role",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_pengadaan",
                table: "pengadaan",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_divisi",
                table: "divisi",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK__pengadaan__idBar__3C69FB99",
                table: "pengadaan",
                column: "idBarang",
                principalTable: "Product",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK__pengadaan__idDiv__3B75D760",
                table: "pengadaan",
                column: "idDivisi",
                principalTable: "divisi",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK__pengadaan__idSta__3E52440B",
                table: "pengadaan",
                column: "idStatus",
                principalTable: "status",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK__pengadaan__idSup__3D5E1FD2",
                table: "pengadaan",
                column: "idSupplier",
                principalTable: "supplier",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK__Product__idSatua__37A5467C",
                table: "Product",
                column: "idSatuan",
                principalTable: "satuan",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK__Product__idSuppl__38996AB5",
                table: "Product",
                column: "idSupplier",
                principalTable: "supplier",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
