using Prism.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfControlLibrary1
{
    public interface IApplicationCommand
    {
        CompositeCommand NavigateCommand { get; }
    }
    public class ApplicationCommand : IApplicationCommand
    {
        public CompositeCommand NavigateCommand { get; } = new CompositeCommand();
    }
}
