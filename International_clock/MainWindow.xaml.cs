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

namespace International_clock
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

        async void InitilizeTimeMoscow()
        {
           while (true)
           {
               
                _MoscowTime.Text= DateTime.Now.ToLongTimeString();
                await Task.Delay(1000);
            }
        }
        async void InitilizeNewYTime()
        {
            TimeZoneInfo nyTimeZone = TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time");
           
            while (true)
            {
                DateTime currentUtcTime = DateTime.Now;
               _NewYTime.Text = TimeZoneInfo.ConvertTime(currentUtcTime, nyTimeZone).ToLongTimeString();
                await Task.Delay(1000);
            }
        }
        async void InitilizePekinTime()
        {
            TimeZoneInfo nyTimeZone = TimeZoneInfo.FindSystemTimeZoneById("China Standard Time");

            while (true)
            {
                DateTime currentUtcTime = DateTime.Now;
                _PekinTime.Text = TimeZoneInfo.ConvertTime(currentUtcTime, nyTimeZone).ToLongTimeString();
                await Task.Delay(1000);
            }
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            InitilizeTimeMoscow();
            InitilizeNewYTime();
            InitilizePekinTime();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Асинхронно работающая кнопка Button_1");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Асинхронно работающая кнопка Button_2");
        }
    }
}