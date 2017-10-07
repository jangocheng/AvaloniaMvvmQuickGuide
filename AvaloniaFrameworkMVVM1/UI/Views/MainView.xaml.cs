using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using AMQG.UI.ViewModels;

namespace AMQG.UI.Views
{
    public partial class MainView : Window
    {
        public MainView()
        {
            this.InitializeComponent();
            this.AttachDevTools();
        }


    }
}
