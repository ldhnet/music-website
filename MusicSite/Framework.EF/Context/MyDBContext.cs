using System.Text;
using Framework.Utility.Config;
using Framework.Utility.ViewModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;

namespace Framework.EF.Context
{
    public  class MyDBContext : DbContext
    {
        private  string _connectionString = GlobalConfig.SystemConfig.DBConnectionString;
        public string myguid { get; set; }
        public MyDBContext() {
            myguid = "MyDBContext" + Guid.NewGuid().ToString();
        }
         
        public MyDBContext(DbContextOptions<MyDBContext> options) : base(options)//options: GeContexttOptions(options)
        {
            myguid = Guid.NewGuid().ToString();
            ChangeTracker.StateChanged += UpdateEntityOnChanged;
            ChangeTracker.Tracked += UpdateEntityOnChanged;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseLazyLoadingProxies();//启用懒加载   
            if (!optionsBuilder.IsConfigured)
            { 
                if (string.IsNullOrEmpty(_connectionString))
                {
                    // _connectionString = "server=.;uid=root;pwd=123456;port=3306;database=tp_music;Allow User Variables=True;sslMode=None";
                    _connectionString = "server=.;userid=root;pwd=123456;port=3306;database=tp_music;Allow User Variables=True;sslMode=None";
                }

                optionsBuilder.UseMySql(_connectionString, ServerVersion.Create(8, 0, 22, ServerType.MySql));

            }
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        { 
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(MyDBContext).Assembly);
             
            base.OnModelCreating(modelBuilder);
        }

        private static void UpdateEntityOnChanged(object? sender, EntityEntryEventArgs e)
        {
            if (e.Entry.Entity is BaseEntity entityopt)
            {
                switch (e.Entry.State)
                {
                    case EntityState.Deleted:
                        entityopt.update_time = DateTime.Now;
                        entityopt.update_by = "system";
                        break;
                    case EntityState.Modified:
                        entityopt.update_time = DateTime.Now;
                        entityopt.update_by = "system";
                        break;
                    case EntityState.Added:
                        entityopt.create_time = DateTime.Now;
                        entityopt.create_by = "system";
                        break;
                }
            } 
        }
    }
}
