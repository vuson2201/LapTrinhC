using Module2.ViewModels;
using Module2.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using WpfControlLibrary1;

namespace Module2
{
    public class Module2Module : IModule
    {
        private readonly RegionManager _regionManager;

        public Module2Module(RegionManager regionManager)
        {
            _regionManager = regionManager;
        }
        public void OnInitialized(IContainerProvider containerProvider)
        {
            _regionManager.RegisterViewWithRegion(RegionNames.OutLookGroupRegion,typeof(ContextGroup));
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<ViewA, ViewAViewModel>();
        }
    }
}