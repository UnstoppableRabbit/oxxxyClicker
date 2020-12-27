using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Configuration;

namespace WpfApp3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MediaPlayer oxxy1;
        MediaPlayer oxxy2;
        public MainWindow()
        {
            oxxy1 = new MediaPlayer();
            oxxy2 = new MediaPlayer();
            
            InitializeComponent();

            qwe.Text = Properties.Settings.Default.count.ToString();


            Style s = new Style();
            s.Setters.Add(new Setter(UIElement.VisibilityProperty, Visibility.Collapsed));
            TabOxy.ItemContainerStyle = s;
        }
        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            oxxy1.Open(new Uri(@"C:\Users\ASUS\Downloads\Oxxxymiron_-_Do_zimy_47829574.mp3", UriKind.Absolute));
            oxxy1.Play();
            oxxy1.Volume = 0.01;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            oxxy2.Open(new Uri(@"C:\Users\ASUS\Downloads\10e1076dfd6c701.mp3", UriKind.Absolute));
            oxxy2.Volume = 0.1;
            oxxy2.Play();

            Properties.Settings.Default.count += 1;
            Properties.Settings.Default.Save();
            qwe.Text = Properties.Settings.Default.count.ToString();

            switch (Properties.Settings.Default.count)
            {
                case 7376:
                    qwerty.ImageSource = new BitmapImage(new Uri(@"C:\Users\ASUS\Downloads\ac0b4c5133be5e6d2fe7326c6c47ebd6.jpg", UriKind.Relative));
                    break;
            }
        }

        private void mute_button_Click(object sender, RoutedEventArgs e)
        {
            if (oxxy1.Volume == 0)
            {
                oxxy1.Volume = 0.01;
                muteImage.Source = new BitmapImage(new Uri(@"C:\Users\ASUS\Downloads\play.jpg", UriKind.RelativeOrAbsolute));
            }
            else
            {
                oxxy1.Volume = 0;
                muteImage.Source = new BitmapImage(new Uri(@"C:\Users\ASUS\Downloads\mute.jpg", UriKind.RelativeOrAbsolute));
            }
                
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            TabOxy.SelectedIndex = 1;
        }
        private void Back_Click(object sender, RoutedEventArgs e)
        {
            TabOxy.SelectedIndex = 0;
        }

        private void Double_missclick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("qwe");
        }

    }
}
