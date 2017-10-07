using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace AMQG.UI.Views
{
    public class OrderView : UserControl
    {
        public OrderView()
        {
            this.InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
