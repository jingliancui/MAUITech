using Microsoft.UI.Xaml.Controls;

namespace SampleApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            Loaded += MainPage_Loaded;
        }

        private void MainPage_Loaded(object? sender, EventArgs e)
        {
            var winCombo = picker.Handler!.PlatformView as ComboBox;
            winCombo!.IsEditable = true;
        }
    }

}
