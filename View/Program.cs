using Model;
using Ninject;
using Presenter.Forms;
using System;
using System.Windows.Forms;

namespace View
{
    public static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Ninject.StandardKernel kernel = new StandardKernel();
            kernel.Bind<ApplicationContext>().ToConstant(new ApplicationContext());
            kernel.Bind<ITimer>().To<WinFormTimer>();
            kernel.Bind<IAdminView>().To<AdminView>();
            kernel.Bind<IChooseRoleView>().To<ChooseRoleView>();
            kernel.Bind<IUserLoginView>().To<UserLoginView>();
            kernel.Bind<IUserView>().To<UserView>();


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ChooseRoleView());
        }
        internal class WinFormTimer : System.Windows.Forms.Timer, ITimer { }

    }
}
