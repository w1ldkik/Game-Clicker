using GameClicker.BLL;
using GameClicker.DAL;
using GameClicker.DAL.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;

namespace GameClicker.UI
{
     static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            

            var services = new ServiceCollection();
            ConfigureServices(services);
            using (ServiceProvider serviceProvider = services.BuildServiceProvider())
            {
                var mainForm = serviceProvider.GetRequiredService<LoginForm>();
                Application.Run(mainForm);
            }
        }

        private static void ConfigureServices(ServiceCollection services)
        {
            services.AddSingleton<AuthContext>()
                    .AddSingleton<LoginForm>()
                    .AddSingleton<UserRepository>()
                    .AddSingleton<RegistrationService>()
                    .AddSingleton<LoginService>();
            
        }
    }
}
