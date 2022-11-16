using Infragistics.Controls.Menus;
using Infragistics.Windows.OutlookBar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfControlLibrary1;
using WpfLibrary1;

namespace Module1.Menus
{
    /// <summary>
    /// Interaction logic for MailGroup.xaml
    /// </summary>
    public partial class MailGroup : OutlookBarGroup,BarGroup
    {
        public MailGroup()
        {
            InitializeComponent();
        }

        public string DefaultNavigationPath
        {
            get
            {
                var item = DataTree.SelectionSettings.SelectedNodes[0] as XamDataTreeNode;
                if (item != null)
                    return ((NavigationItem)item.Data).NavigationPath;
                return "MailList";
            }
        }
    }
}
