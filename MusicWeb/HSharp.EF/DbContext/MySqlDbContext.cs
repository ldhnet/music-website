using HSharp.Util;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging; 
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection;

namespace HSharp.Data.EF.DbContext
{
    public class MySqlDbContext : Microsoft.EntityFrameworkCore.DbContext
    { 

        private string ConnectionString { get; set; }

        public MySqlDbContext(string connectionString)
        {
            ConnectionString = connectionString;
        }

        #region 重载

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        { 
            optionsBuilder.UseMySql(ConnectionString, ServerVersion.AutoDetect(ConnectionString), p => p.CommandTimeout(GlobalContext.SystemConfig.DBCommandTimeout));
            optionsBuilder.AddInterceptors(new DbCommandCustomInterceptor()); 
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            Assembly entityAssembly = Assembly.Load(new AssemblyName("HSharp.Entity"));
            IEnumerable<Type> typesToRegister = entityAssembly.GetTypes().Where(p => !string.IsNullOrEmpty(p.Namespace))
                                                                         .Where(p => !string.IsNullOrEmpty(p.GetCustomAttribute<TableAttribute>()?.Name));
            foreach (Type type in typesToRegister)
            {
                dynamic configurationInstance = Activator.CreateInstance(type);
                modelBuilder.Model.AddEntityType(type);
            }
            foreach (var entity in modelBuilder.Model.GetEntityTypes())
            {
                PrimaryKeyConvention.SetPrimaryKey(modelBuilder, entity.Name);
                string currentTableName = modelBuilder.Entity(entity.Name).Metadata.GetTableName();
                modelBuilder.Entity(entity.Name).ToTable(currentTableName);

                //var properties = entity.GetProperties();
                //foreach (var property in properties)
                //{
                //    ColumnConvention.SetColumnName(modelBuilder, entity.Name, property.Name);
                //}
            }

            base.OnModelCreating(modelBuilder);
        }

        #endregion 重载
    }
}