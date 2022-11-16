using Module1.Menus;
using System.Windows.Controls;
using WpfControlLibrary1;

namespace Module1.Views
{
    /// <summary>
    /// Interaction logic for MailList
    /// </summary>
    [DependentViewAtribute(RegionNames.RibbonRegion,typeof(HomeTap))]
    public partial class MailList : UserControl
    {
        public MailList()
        {
            InitializeComponent();
        }
    }
}
