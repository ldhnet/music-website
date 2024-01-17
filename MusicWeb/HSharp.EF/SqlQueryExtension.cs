using HSharp.Util;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Threading.Tasks;

namespace HSharp.Data.EF
{
    public static class SqlQueryExtension
    { 
		public static async Task<IList<T>> SqlQuery<T>(this Microsoft.EntityFrameworkCore.DbContext db, string sql, params object[] parameters) where T : class
        {
            using (var db2 = new ContextForQueryType<T>(db.Database.GetDbConnection()))
            {
                if (parameters != null && parameters.Length > 0)
                {
                    return await db2.Set<T>().FromSqlRaw(sql, parameters).ToListAsync();
                }
                else
                {
					return await db2.Set<T>().FromSqlRaw(sql).ToListAsync();
				}
            }
        }
		private class ContextForQueryType<T> : Microsoft.EntityFrameworkCore.DbContext where T : class
        {
            private readonly DbConnection connection;

            public ContextForQueryType(DbConnection connection)
            {
                this.connection = connection;
            }

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                // switch on the connection type name to enable support multiple providers
                string dbType = GlobalContext.SystemConfig.DBProvider;
                switch (dbType)
                {
                    case "SqlServer":
                        optionsBuilder.UseSqlServer(connection, options => options.EnableRetryOnFailure());
                        break;

                    case "MySql":
                        optionsBuilder.UseMySql(connection, ServerVersion.AutoDetect(connection.ConnectionString), options => options.EnableRetryOnFailure());
                        break;

					case "SQLite":
						optionsBuilder.UseSqlite(connection);
						break;

					case "Oracle": break;
                    default: throw new Exception("未找到数据库配置");
                }
                base.OnConfiguring(optionsBuilder);
            }

            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                modelBuilder.Entity<T>(p => { p.HasNoKey(); });
                base.OnModelCreating(modelBuilder);
            }
        }
    }
}