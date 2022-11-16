using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfControlLibrary1;
using WpfLibrary1;

namespace Module1.ViewModels
{
    public class MailGroupViewModel:ViewModelBase
    {
		private ObservableCollection<NavigationItem> _items;
        public ObservableCollection<NavigationItem> Items
        {
			get { return _items; }
			set { SetProperty(ref _items, value); }
		}
		private DelegateCommand<NavigationItem> _selectedCommand;
		private readonly IApplicationCommand _applicationCommand;

		public DelegateCommand<NavigationItem> SelectedCommand =>
            _selectedCommand ?? (_selectedCommand = new DelegateCommand<NavigationItem>(ExecuteSelectedCommand));

		void ExecuteSelectedCommand(NavigationItem navigationItem)
		{
			if (navigationItem != null)
				_applicationCommand.NavigateCommand.Execute(navigationItem.NavigationPath);
		}
		public MailGroupViewModel(IApplicationCommand applicationCommand)
		{
			GenerateMenu();
			_applicationCommand = applicationCommand;
		}
		void GenerateMenu()
		{
			Items = new ObservableCollection<NavigationItem>();

			var root = new NavigationItem() { Caption = "Person Folder", NavigationPath = "MailList?id=Default" };
			root.Items.Add(new NavigationItem() { Caption = "Inbox", NavigationPath = "MailList?id=Inbox" });
            root.Items.Add(new NavigationItem() { Caption = "Delete", NavigationPath = "MailList?id=Delete" });
            root.Items.Add(new NavigationItem() { Caption = "Sent", NavigationPath = "MailList?id=Sent" });

            Items.Add(root);
		}
	}
}
