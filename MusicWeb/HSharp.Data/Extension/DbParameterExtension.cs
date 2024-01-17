using Microsoft.Data.SqlClient;
using Microsoft.Data.Sqlite;
using MySqlConnector;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Data.Common;

namespace HSharp.Data.Extension
{
    public class DbParameterExtension
    {
        /// <summary>
        /// 根据配置文件中所配置的数据库类型
        /// 来创建相应数据库的参数对象
        /// </summary>
        /// <returns></returns>
        public static DbParameter CreateDbParameter()
        {
            switch (DbHelper.DbType)
            {
                case DatabaseType.SqlServer:
                    return new SqlParameter();

                case DatabaseType.MySql:
                    return new MySqlParameter();

                case DatabaseType.SQLite:
                    return new SqliteParameter();

                default:
                    throw new Exception("数据库类型目前不支持！");
            }
        }

        /// <summary>
        /// 根据配置文件中所配置的数据库类型
        /// 来创建相应数据库的参数对象
        /// </summary>
        /// <returns></returns>
        public static DbParameter CreateDbParameter(string paramName, object value)
        {
            DbParameter param = CreateDbParameter();
            param.ParameterName = paramName;
            param.Value = value;
            return param;
        }

        /// <summary>
        /// 转换对应的数据库参数
        /// </summary>
        /// <param name="dbParameter">参数</param>
        /// <returns></returns>
        public static DbParameter[] ToDbParameter(DbParameter[] dbParameter)
        {
            int i = 0;
            int size = dbParameter.Length;
            DbParameter[] _dbParameter = null;
            switch (DbHelper.DbType)
            {
                case DatabaseType.SqlServer:
                    _dbParameter = new SqlParameter[size];
                    while (i < size)
                    {
                        _dbParameter[i] = new SqlParameter(dbParameter[i].ParameterName, dbParameter[i].Value);
                        i++;
                    }
                    break;

                case DatabaseType.MySql:
                    _dbParameter = new MySqlParameter[size];
                    while (i < size)
                    {
                        _dbParameter[i] = new MySqlParameter(dbParameter[i].ParameterName, dbParameter[i].Value);
                        i++;
                    }
                    break;

                case DatabaseType.SQLite:
                    _dbParameter = new SqliteParameter[size];
                    while (i < size)
                    {
                        _dbParameter[i] = new SqliteParameter(dbParameter[i].ParameterName, dbParameter[i].Value);
                        i++;
                    }
                    break;

                case DatabaseType.Oracle:
                    _dbParameter = new OracleParameter[size];
                    while (i < size)
                    {
                        _dbParameter[i] = new OracleParameter(dbParameter[i].ParameterName, dbParameter[i].Value);
                        i++;
                    }
                    break;

                default:
                    throw new Exception("数据库类型目前不支持！");
            }
            return _dbParameter;
        }
    }
}