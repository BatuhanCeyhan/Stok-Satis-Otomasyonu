using Microsoft.Extensions.DependencyInjection;
using Stok.Bussinuss.Abstract;
using Stok.Bussinuss.Concrete;
using Stok.DataAccsess.Abstract;
using Stok.DataAccsess.Concrete.Entity_Framework.Repository;
using Stok.Model.Entity_Framework;
using Stok.WinUI.PersonelIslemleri;

namespace Stok.WinUI
{
    internal static class Program
    {
        private static void ConfigureServices(ServiceCollection services)
        {
            services.AddTransient<frmLogin>();
            services.AddTransient<frmAdmin>();
            services.AddTransient<frmPersonel>();
            services.AddTransient<frmPersonelIslem>();
            services.AddTransient<UrunIslemleri>();
            services.AddTransient<SatýsIslemleri>();
            services.AddTransient<StokIslemleri>();
            services.AddTransient<IadeIslemleri>();

            services.AddSingleton<IGirisBs, GirisBs>();
            services.AddSingleton<IGirisRepository, EfGirisRepository>();

            services.AddSingleton<IUrunBs, UrunBs>();
            services.AddSingleton<IUrunRepository,EfUrunRepository>();

            services.AddSingleton<ISatýsBs, SatýsBs>();
            services.AddSingleton<ISatýsRepository, EfSatýsRepository>();



        }

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            ServiceCollection services = new ServiceCollection();
            ConfigureServices(services);

            FormFactory.SetServicesProvider(services.BuildServiceProvider());
            Application.Run(FormFactory.CreatefrmLogin());

        }
    }
}