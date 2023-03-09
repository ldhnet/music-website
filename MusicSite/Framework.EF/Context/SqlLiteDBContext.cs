using System.Text;
using Framework.Utility.Config;
using Framework.Utility.ViewModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking; 

namespace Framework.EF.Context
{
    public  class SqlLiteDBContext : DbContext
    {
        private  string _connectionString = GlobalConfig.SystemConfig.DBConnectionString;
        public string myguid { get; set; }
        public SqlLiteDBContext() {
            myguid = "MyDBContext" + Guid.NewGuid().ToString();
        }
         
        public SqlLiteDBContext(DbContextOptions<MyDBContext> options) : base(options)//options: GeContexttOptions(options)
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
                string connecttext = "Filename=D:\\DB\\tp_music.db"; 
                optionsBuilder.UseSqlite(connecttext);

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
