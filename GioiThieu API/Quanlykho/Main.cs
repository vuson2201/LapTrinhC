using Caliburn.Micro;
using Quanlykho.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Quanlykho
{
    internal class Main : BootstrapperBase
    {
        public Main()
        {
            Initialize();
        }
        protected override void OnStartup(object sender, StartupEventArgs e)
        {
            DisplayRootViewForAsync<KhoViewModel>();
        }
    }
}
