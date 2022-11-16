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

namespace Module2
{
    /// <summary>
    /// Interaction logic for ContextGroup.xaml
    /// </summary>
    public partial class ContextGroup : OutlookBarGroup,BarGroup
    {
        public ContextGroup()
        {
            InitializeComponent();
        }

        public string DefaultNavigationPath => "ViewA";
    }
}
