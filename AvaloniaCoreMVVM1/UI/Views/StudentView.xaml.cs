using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using AMQG.UI.VML;

namespace AMQG.UI.Views
{
    public class StudentView : UserControl
    {
        public StudentView()
        {
            this.InitializeComponent();
            ViewModelLocator.SetAutoHookedUpViewModel(this, true);
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
