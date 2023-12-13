using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;
using SiteManagementApi.Data.Context;

namespace SiteManagementApi.Data.Classes
{
    public class Helpers
    {
        public static bool TableExists(MigrationBuilder migrationBuilder, string tableName) {
            bool exists = true;
            string sql = "SELECT 1 FROM sys.tables AS T " +
                     "INNER JOIN sys.schemas AS S ON T.schema_id = S.schema_id " +
                     "WHERE S.Name = 'SchemaName' AND T.Name = '" + tableName + "'";

            DashboardContext context = new DashboardContext();
            using (context)
            {
                //exists = context.Database.ExecuteSql(sql);
            }
           
            return exists;
        }
    }
}
