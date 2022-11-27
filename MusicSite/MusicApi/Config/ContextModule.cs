using Autofac;
using Framework.Admin;

namespace MusicApi.Config
{
    public class ContextModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            //builder.Register(c => new MyAdminContext() { CurrentID = 1, CurrentMonth = DateTime.Now })
            //    .AsSelf().InstancePerLifetimeScope(); 

            //builder.Register(context =>
            //{
            //    MyAdminContext _context = new MyAdminContext();
            //    _context.CurrentID = 1;
            //    _context.CurrentMonth = DateTime.Now;
            //    return _context;
            //}).AsSelf().InstancePerLifetimeScope(); 
        } 
    }

}
