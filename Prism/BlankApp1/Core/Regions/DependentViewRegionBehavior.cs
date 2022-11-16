using Prism.Ioc;
using Prism.Regions;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using WpfControlLibrary1;

namespace BlankApp1.Core.Regions
{
    public class DependentViewRegionBehavior:RegionBehavior
    {
        public const string BehaviKey = "DependentViewRegionBehavior";
        private readonly IContainerExtension _container;
        Dictionary<object,List<DependentViewInfor>> _dependentViewCache = new Dictionary<object,List<DependentViewInfor>>();
        public DependentViewRegionBehavior(IContainerExtension container)
        {
            _container = container;
        }
        protected override void OnAttach()
        {
            Region.ActiveViews.CollectionChanged += ActiveViews_CollectionChanged;
        }

        private void ActiveViews_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            if(e.Action==NotifyCollectionChangedAction.Add)
            {
                foreach (var view in e.NewItems)
                {
                    var dependentView = new List<DependentViewInfor>();
                    if(_dependentViewCache.ContainsKey(view))
                        dependentView = _dependentViewCache[view];
                    else
                    {
                        var atts = GetCustomAttributes<DependentViewAtribute>(view.GetType());
                        foreach (var att in atts)
                        {
                            var info = CreateDependentViewInfor(att);
                            dependentView.Add(info);
                        }
                        _dependentViewCache.Add(view, dependentView);
                    }
                    dependentView.ForEach(item => Region.RegionManager.Regions[item.Region].Add(item.View));
                }
            }
            else if(e.Action==NotifyCollectionChangedAction.Remove)
            {
                foreach (var oldview in e.OldItems)
                {
                    if (_dependentViewCache.ContainsKey(oldview))
                    {
                        var dependentView = _dependentViewCache[oldview];
                        dependentView.ForEach(item => Region.RegionManager.Regions[item.Region].Remove(item.View));
                        if(!ShouldKeepAlive(oldview))
                            _dependentViewCache.Remove(oldview);
                    }
                }
            }
        }

        private bool ShouldKeepAlive(object oldview)
        {
            var regionLifetime = GetViewOrDataContextLifetime(oldview);
            if (regionLifetime != null)
                return regionLifetime.KeepAlive;
            return true;
        }
        IRegionMemberLifetime GetViewOrDataContextLifetime(object view)
        {
            if(view is IRegionMemberLifetime lifetime)
                return lifetime;
            if(view is FrameworkElement framework)
                return framework.DataContext as IRegionMemberLifetime;
            return null;
        }
        DependentViewInfor CreateDependentViewInfor(DependentViewAtribute atribute)
        {
            var info = new DependentViewInfor();
            info.Region = atribute.Region;
            info.View = _container.Resolve(atribute.Type);
            return info;
        }
        private static IEnumerable<T> GetCustomAttributes<T>(Type type)
        {
            return type.GetCustomAttributes(typeof(T), true).OfType<T>();
        }
    }
}
