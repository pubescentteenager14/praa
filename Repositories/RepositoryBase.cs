using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Practika1.Repositories
{
    public abstract class RepositoryBase
    {
        private readonly string _connectionString;
        public RepositoryBase()
        {
            _connectionString = "Data Source = DESKTOP-AVDMVC2\\MSSQLSERVER2; Database = MVVMLoginDb; Integrated Security=True";
            //Data Source = DESKTOP - AVDMVC2\MSSQLSERVER2; Initial Catalog = MVVMLoginDb; Integrated Security = True
            //"Server=(DESKTOP-AVDMVC2\\MSSQLSERVER2); Database=MVVMLoginDb; Integrated Security=true"
            //Data Source = MSSQL$MSSQLSERVER2; Initial Catalog = MVVMLoginDb; Integrated Security = True
        }
        protected SqlConnection GetConnection()
        {
            return new SqlConnection( _connectionString );
        }
    }
}
