using Microsoft.Extensions.DependencyInjection;
using Stok.WinUI.PersonelIslemleri;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stok.WinUI
{
    public class FormFactory
    {
        private static IServiceProvider serviceProvider;

        public static void SetServicesProvider(IServiceProvider _serviceProvider)
        {
            serviceProvider = _serviceProvider;
        }
        public static frmLogin CreatefrmLogin()
        {
            return serviceProvider.GetRequiredService<frmLogin>();
        }
        public static frmPersonel CreatefrmPersonel()
        {
            return serviceProvider.GetRequiredService<frmPersonel>();
        }
        public static frmAdmin CreatefrmAdmin()
        {
            return serviceProvider.GetRequiredService<frmAdmin>();
        }
        public static frmPersonelIslem CreatefrmPersonelIslem()
        {
            return serviceProvider.GetRequiredService<frmPersonelIslem>();
        }
        public static UrunIslemleri CreateUrunIslem()
        {
            return serviceProvider.GetRequiredService<UrunIslemleri>();
        }
        public static SatısIslemleri CreateSatisIslemleri()
        {
            return serviceProvider.GetRequiredService<SatısIslemleri>();
        }
        public static StokIslemleri CreateStokIslemleri()
        {
            return serviceProvider.GetRequiredService<StokIslemleri>();
        }
        public static IadeIslemleri CreateIadeIslemleri()
        { 
            return serviceProvider.GetRequiredService<IadeIslemleri>() ;
        }

    }
}
