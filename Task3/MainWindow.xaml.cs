using System.Windows;
using System.Windows.Controls;

namespace Task3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            TextBox.FontSize = 20;
            TextBox.TextAlignment = TextAlignment.Left;
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            if (sender is RadioButton radioButton)
            {
                if (int.TryParse(radioButton.Content.ToString(), out int value))
                {
                    TextBox.FontSize = value;
                }
            }
        }

        private void LeftRadioButton_Checked2(object sender, RoutedEventArgs e)
        {
            TextBox.TextAlignment = TextAlignment.Left;
        }

        private void RightRadioButton_Checked2(object sender, RoutedEventArgs e)
        {
            TextBox.TextAlignment = TextAlignment.Right;
        }

        private void CenterRadioButton_Checked2(object sender, RoutedEventArgs e)
        {
            TextBox.TextAlignment = TextAlignment.Center;
        }
    }
}