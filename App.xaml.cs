using Avalonia;
using Avalonia.Markup.Xaml;

namespace ServiceBusExplorer
{
    public class App : Application
    {
        public override void Initialize()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
