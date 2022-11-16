using Infragistics.Windows.OutlookBar;
using Infragistics.Windows.Ribbon;
using Prism.Regions;
using System.Windows;
using WpfControlLibrary1;

namespace BlankApp1.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : XamRibbonWindow
    {
        private readonly IApplicationCommand _applicationCommand;

        public MainWindow(IApplicationCommand applicationCommand)
        {
            InitializeComponent();
            _applicationCommand = applicationCommand;
        }

        private void SelectGroupChanged(object sender, RoutedEventArgs e)
        {
            var group = ((XamOutlookBar)sender).SelectedGroup as BarGroup;
            if(group!=null)
            {
                _applicationCommand.NavigateCommand.Execute(group.DefaultNavigationPath);
            }
        }
    }
}
