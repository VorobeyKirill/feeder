using Model;
using Model.Service;
using Ninject;
using Presenter;
using Presenter.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
            kernel.Bind<IUserLoginService>().To<UserLoginService>();
            kernel.Bind<IUserService>().To<UserService>();

            kernel.Get<ChooseRolePresenter>().Run();
            Application.Run(kernel.Get<ApplicationContext>());
        }

        internal class WinFormTimer : System.Windows.Forms.Timer, ITimer { }
    }
}
