using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Task5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            UpdateBackground();
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            UpdateBackground();
        }
        private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            UpdateBackground();
        }

        private void UpdateBackground()
        {
            byte red = sliderRed.Value;
            byte green = sliderGreen.Value;
            byte blue = sliderBlue.Value;

            if(CBRed.IsChecked == false)
            {
                red = 0;
            }
            if(CBGreen.IsChecked == false) 
            { 
                green = 0;
            }
            if(CBBlue.IsChecked == false) 
            {
                blue = 0;
            }
            Background = new SolidColorBrush(Color.FromRgb(red, green, blue));
        }
    }
}