using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SegurosABC.Repositories.Migrations
{
    public partial class DB_V2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var createProcSql = @"CREATE PROCEDURE ConsultaPagosCliente (@cedula NVARCHAR(25) = NULL) AS BEGIN
                                    DECLARE @sql NVARCHAR(MAX) = N'';
                                    SET @sql += N'SELECT  PG.Cedula, CT.Nombre, PG.FechaPago, PG.Monto FROM Pagos PG '
                                    SET @sql += N'INNER JOIN Clientes CT ON PG.Cedula = CT.Cedula ';

                                    IF(@cedula IS NOT NULL) BEGIN;
                                        SET @sql += N'WHERE PG.Cedula = ''@cedula''';
                                    END;

                                    SET @sql += N'GROUP BY PG.Cedula, CT.Nombre, PG.FechaPago, PG.Monto ';
                                    SET @sql += N'ORDER BY PG.Cedula, PG.FechaPago DESC ';


                                    IF(@cedula IS NOT NULL) BEGIN;
                                        SET @sql = REPLACE(@sql, N'@cedula', @cedula)
                                    END;
    

                                    EXEC sp_executesql @sql
                                END;";
            migrationBuilder.Sql(createProcSql);

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            var dropProcSql = "DROP PROCEDURE ConsultaPagosCliente";
            migrationBuilder.Sql(dropProcSql);
        }
    }
}
