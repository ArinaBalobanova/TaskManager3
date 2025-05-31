using TaskManager;
using Castle.Windsor;
namespace TaskManager3
{
    internal static class Program
    {
        private static WindsorContainer _container;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            _container = new WindsorContainer();
            _container.Install(new WindsorInstaller());

            using (var db = _container.Resolve<AppDbContext>())
            {
                db.Database.EnsureCreated();
            }

            var mainForm = _container.Resolve<TaskListForm>();
            Application.Run(mainForm);
        }
    }
}