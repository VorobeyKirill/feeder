using Feeder.Model.Repository;
using Feeder.Model.Service;
using Feeder.Presenter.Implementations;
using Model;
using Model.Entity;
using Model.Service;
using Ninject;
using Presenter.Forms;
using System;
using System.Windows.Forms;
using View;

namespace Feeder
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Ninject.StandardKernel kernel = new StandardKernel();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            kernel.Bind<ApplicationContext>().ToConstant(new ApplicationContext());
            kernel.Bind<ITimer>().To<WinFormTimer>();
            kernel.Bind<IAdminView>().To<AdminView>();
            kernel.Bind<IChooseRoleView>().To<ChooseRoleView>();
            kernel.Bind<IUserLoginView>().To<UserLoginView>();
            kernel.Bind<IUserView>().To<UserView>();
            kernel.Bind<IAdminService>().To<AdminService>();
            kernel.Bind<IChooseRoleService>().To<ChooseRoleService>();
            kernel.Bind<IFeederService>().To<FeederService>();
            kernel.Bind<IUserLoginService>().To<UserLoginService>();
            kernel.Bind<IUserService>().To<UserService>();
            kernel.Bind<AdminPresenter>().ToSelf();
            kernel.Bind<IRepository<User>>().To<UserRepository>();
            kernel.Bind<IRepository<FeederEntity>>().To<FeederRepository>();
            kernel.Bind<IRepository<string>>().To<RequestRepository>();
            kernel.Bind<UserPresenter>().ToSelf(); 

            kernel.Get<ChooseRolePresenter>().Run();
            Application.Run(kernel.Get<ApplicationContext>());
        }

        internal class WinFormTimer : System.Windows.Forms.Timer, ITimer { }
    }
}
