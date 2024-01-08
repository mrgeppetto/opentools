using Microsoft.Extensions.DependencyInjection;
using opentools.ViewModels;
using Serilog;
using System.Windows;

namespace opentools
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly ServiceProvider _serviceProvider;
        public App()
        {
            ServiceCollection services = new();
            ConfigureServices(services);
            _serviceProvider = services.BuildServiceProvider();
            Log.Logger = new LoggerConfiguration()
                .WriteTo.File("log.txt", rollingInterval: RollingInterval.Day)
                .CreateLogger();
        }

        private void ConfigureServices(ServiceCollection services)
        {
            services.AddTransient<MainWindow>();
            services.AddTransient<MainViewModel>();
            services.AddTransient<AppMainViewModel>();
            services.AddTransient<PowerFixViewModel>();
            services.AddTransient<NotesViewModel>();
            services.AddTransient<AboutViewModel>();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);  
            var mainWindow = _serviceProvider.GetService<MainWindow>(); 
            mainWindow?.Show();

        }

    }
}
