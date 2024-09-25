using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp2
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

        private void RedBackground_Click(object sender, RoutedEventArgs e)
        {
            this.Background = System.Windows.Media.Brushes.Red;
            StatusBarItem.Content = "Фон изменен на красный";
        }
        private void GreenBackground_Click(object sender, RoutedEventArgs e)
        {
            this.Background = System.Windows.Media.Brushes.Green;
            StatusBarItem.Content = "Фон изменен на зелёный";
        }
        private void BlueBackground_Click(object sender, RoutedEventArgs e)
        {
            this.Background = System.Windows.Media.Brushes.Blue;
            StatusBarItem.Content = "Фон изменен на синий";
        }
        private void AboutDeveloper_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("помогите у меня отобрали паспорт", "О разработчике", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void MouseMove_RF(object sender, RoutedEventArgs e)
        {
            StatusBarItem.Content = "Изменить фон на красный";
        }
        private void MouseMove_GF(object sender, RoutedEventArgs e)
        {
            StatusBarItem.Content = "Изменить фон на зелёный";
        }
        private void MouseMove_BF(object sender, RoutedEventArgs e)
        {
            StatusBarItem.Content = "Изменить фон на синий";
        }
        private void MouseMove_me(object sender, RoutedEventArgs e)
        {
            StatusBarItem.Content = "узнать о разработчике";
        }
        private void MouseMove_exit(object sender, RoutedEventArgs e)
        {
            StatusBarItem.Content = "закрыть программу";
        }
    }
}