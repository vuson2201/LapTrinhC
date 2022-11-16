using Infragistics.Windows.Ribbon;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlankApp1.Core.Regions
{
    internal class RibbonAdapter : RegionAdapterBase<XamRibbon>
    {
        public RibbonAdapter(IRegionBehaviorFactory regionBehaviorFactory) : base(regionBehaviorFactory)
        {
        }

        protected override void Adapt(IRegion region, XamRibbon regionTarget)
        {
            if(region == null) throw new ArgumentNullException(nameof(region));
            if (regionTarget == null) throw new ArgumentNullException(nameof(regionTarget));
            region.Views.CollectionChanged += (s, e) =>
            {
                if(e.Action==NotifyCollectionChangedAction.Add)
                {
                    foreach (var view in e.NewItems)
                    {
                        AddViewToRegion(view, regionTarget);
                    }
                }
                else if(e.Action==NotifyCollectionChangedAction.Remove)
                {
                    foreach (var view in e.OldItems)
                    {
                        RemoveViewToRegion(view, regionTarget);
                    }
                }
            };
        }
        static void AddViewToRegion(object view,XamRibbon xamRibbon)
        {
            var ribbonTapItem = view as RibbonTabItem;
            if(ribbonTapItem!=null)
                xamRibbon.Tabs.Add(ribbonTapItem);
        }
        static void RemoveViewToRegion(object view, XamRibbon xamRibbon)
        {
            var ribbonTapItem = view as RibbonTabItem;
            if (ribbonTapItem != null)
                xamRibbon.Tabs.Remove(ribbonTapItem);
        }
        protected override IRegion CreateRegion()
        {
            return new SingleActiveRegion();
        }
    }
}
