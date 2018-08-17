using System.Windows.Input;
using Avalonia;
using ReactiveUI;

namespace ServiceBusExplorer.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public MainWindowViewModel()
        {
            MenuExitCommand = ReactiveCommand.Create(() => { Application.Current.Exit(); });
        }

        public ICommand MenuExitCommand { get; }

        public string Greeting => "Hello World!";

        public string ServiceBus => "Hello World!";
    }
}
