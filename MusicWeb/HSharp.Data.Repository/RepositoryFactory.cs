using HSharp.Data.EF;
using HSharp.Data.EF.Database;
using HSharp.Util;
using System;

namespace HSharp.Data.Repository
{
    public class RepositoryFactory
    {
		public Repository _Repository { get { return BaseRepository(); } }

		private Repository BaseRepository()
        {
            IDatabase database = null;
            string dbType = GlobalContext.SystemConfig.DBProvider;
            string dbConnectionString = GlobalContext.SystemConfig.DBConnectionString;
            switch (dbType)
            {
                case "SqlServer":
                    DbHelper.DbType = DatabaseType.SqlServer;
                    database = new SqlServerDatabase(dbConnectionString);
                    break;

                case "MySql":
                    DbHelper.DbType = DatabaseType.MySql;
                    database = new MySqlDatabase(dbConnectionString);
                    break;
				case "SQLite":
					DbHelper.DbType = DatabaseType.SQLite;
                    database = new SQLiteDatabase(dbConnectionString);
                    break;
				case "Oracle":
                    DbHelper.DbType = DatabaseType.Oracle;
                    // 支持Oracle或是更多数据库请参考上面SqlServer或是MySql的写法
                    break;

                default:
                    throw new Exception("未找到数据库配置");
            }
            return new Repository(database);
        }
    }
}