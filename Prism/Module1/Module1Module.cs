using Module1.Menus;
using Module1.ViewModels;
using Module1.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Mvvm;
using Prism.Regions;
using WpfControlLibrary1;

namespace Module1
{
    public class Module1Module : IModule
    {
        private readonly RegionManager _regionManager;

        public Module1Module(RegionManager regionManager)
        {
            _regionManager = regionManager;
        }
        public void OnInitialized(IContainerProvider containerProvider)
        {
            _regionManager.RegisterViewWithRegion(RegionNames.OutLookGroupRegion, typeof(MailGroup));
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            ViewModelLocationProvider.Register<MailGroup,MailGroupViewModel>();
            containerRegistry.RegisterForNavigation<MailList, MailListViewModel>();
        }
    }
}