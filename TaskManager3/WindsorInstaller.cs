using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;


namespace TaskManager
{
    public class WindsorInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            
            container.Register(Component.For<AppDbContext>().LifestyleTransient());

            container.Register(Component.For<TaskListForm>().ImplementedBy<TaskListForm>());

        }
    }
}
