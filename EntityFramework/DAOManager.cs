using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Linq;
using System.Text;

namespace EntityFramework
{
    class DAOManager
    {
        private MODEL.pelisContext context;
        public DAOManager(MODEL.pelisContext context)
        {
            this.context = context;
        }

        public static DataTable DataTable(this DbContext context,
           string sqlQuery, params DbParameter[] parameters)
        {
            DataTable dataTable = new DataTable();
            DbConnection connection = context.Database.GetDbConnection();
            DbProviderFactory dbFactory = DbProviderFactories.GetFactory(connection);
            using (var cmd = dbFactory.CreateCommand())
            {
                cmd.Connection = connection;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = sqlQuery;
                if (parameters != null)
                {
                    foreach (var item in parameters)
                    {
                        cmd.Parameters.Add(item);
                    }
                }
                using (DbDataAdapter adapter = dbFactory.CreateDataAdapter())
                {
                    adapter.SelectCommand = cmd;
                    adapter.Fill(dataTable);
                }
            }
            return dataTable;
        }

        public object GetPelis()
        {
            List<MODEL.Film> lstPelis = context.Film.ToList();
            return lstPelis;
        }
    }
}
