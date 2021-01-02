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
using System.Windows.Media.Animation;
using System.Timers;


namespace WpfApp3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MediaPlayer oxxy1;
        MediaPlayer oxxy2;
        MediaPlayer miss;
        MediaPlayer miss1;
        MediaPlayer gavno;
        MediaPlayer gavno1;

        int j = 0;
        int k = 0;
        public MainWindow()
        {
            oxxy1 = new MediaPlayer();
            oxxy2 = new MediaPlayer();

            miss = new MediaPlayer();
            miss1 = new MediaPlayer();

            gavno = new MediaPlayer();
            gavno1 = new MediaPlayer();

            InitializeComponent();

            qwe.Text = Properties.Settings.Default.count.ToString();
            qwe2.Text = Properties.Settings.Default.count2.ToString();

            Style s = new Style();
            s.Setters.Add(new Setter(UIElement.VisibilityProperty, Visibility.Collapsed));
            TabOxy.ItemContainerStyle = s;

            System.Windows.Threading.DispatcherTimer timer = new System.Windows.Threading.DispatcherTimer();

            timer.Tick += new EventHandler(timerTick);
            timer.Interval = new TimeSpan(0, 2, 30);
            timer.Start();
        }

        private void timerTick(object sender, EventArgs e)
        {
        
            switch (j % 3) 
            {
                case 0:
                   oxxy1.Open(new Uri(@"C:\Users\ASUS\Downloads\Oxxxymiron_-_Ultima_Thule_47829572.mp3", UriKind.Absolute));
                   oxxy1.Play();
                break;

                case 1:
                    oxxy1.Open(new Uri(@"C:\Users\ASUS\Downloads\Oxxxymiron_-_Krokodilovy_sljozy_47830031.mp3", UriKind.Absolute));
                    oxxy1.Play();
                break;

                case 2:
                    oxxy1.Open(new Uri(@"C:\Users\ASUS\Downloads\Oxxxymiron_-_Do_zimy_47829574.mp3", UriKind.Absolute));
                    oxxy1.Play();
                break;
            }
            j++;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            oxxy1.Open(new Uri(@"C:\Users\ASUS\Downloads\Oxxxymiron_-_Do_zimy_47829574.mp3", UriKind.Absolute));
            oxxy1.Play();
            oxxy1.Volume = 0.02;
            gavno.Volume = 0.1;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            oxxy2.Open(new Uri(@"C:\Users\ASUS\Downloads\10e1076dfd6c701.mp3", UriKind.Absolute));
            oxxy2.Volume = 0.1;
            oxxy2.Play();

            Properties.Settings.Default.count += 1;
            Properties.Settings.Default.Save();
            qwe.Text = Properties.Settings.Default.count.ToString();

            Random rnd = new Random();
            int value = rnd.Next(1, 100);

            if (value == 13)
            {
                TranslateTransform gnoj = new TranslateTransform();
                slava.RenderTransform = gnoj;
                DoubleAnimation animX = new DoubleAnimation(0, 200, TimeSpan.FromSeconds(1));
                gnoj.BeginAnimation(TranslateTransform.XProperty, animX);
            }
            if (value == 50)
            {
                TranslateTransform jhon = new TranslateTransform();
                jhony.RenderTransform = jhon;
                DoubleAnimation animY = new DoubleAnimation(0, -186, TimeSpan.FromSeconds(1));
                jhon.BeginAnimation(TranslateTransform.YProperty, animY);
            }
            if (value == 10)
            {
                TranslateTransform qwer = new TranslateTransform();
                lsp.RenderTransform = qwer;
                DoubleAnimation animX = new DoubleAnimation(0, -700, TimeSpan.FromSeconds(2));
                qwer.BeginAnimation(TranslateTransform.XProperty, animX);
                DoubleAnimation animY = new DoubleAnimation(0, -500, TimeSpan.FromSeconds(2));
                qwer.BeginAnimation(TranslateTransform.YProperty, animY);
            }
            if (value == 25)
            {
                TranslateTransform pos = new TranslateTransform();
                porchy.RenderTransform = pos;
                DoubleAnimation animY = new DoubleAnimation(0, 160, TimeSpan.FromSeconds(1));
                pos.BeginAnimation(TranslateTransform.YProperty, animY);
            }
            //switch (Properties.Settings.Default.count)
            //{
            //    case 7376:
            //        qwerty.ImageSource = new BitmapImage(new Uri(@"C:\Users\ASUS\Downloads\ac0b4c5133be5e6d2fe7326c6c47ebd6.jpg", UriKind.Relative));
            //        break;
            //}
        }

        private void mute_button_Click(object sender, RoutedEventArgs e)
        {
            if (oxxy1.Volume == 0)
            {
                oxxy1.Volume = 0.02;
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
            Random rnd = new Random();
            int value = rnd.Next(1, 3);
            if (value == 1)
                miss.Open(new Uri(@"C:\Users\ASUS\Downloads\otnoshenie.mp3", UriKind.Absolute));
            else
                miss.Open(new Uri(@"C:\Users\ASUS\Downloads\avprochempohui.mp3", UriKind.Absolute));

            miss.Play();
            Properties.Settings.Default.count2 -= 1;
            Properties.Settings.Default.Save();
            qwe2.Text = Properties.Settings.Default.count2.ToString();

        }
        private void gnoynij_Click(object sender, RoutedEventArgs e)
        {
            TranslateTransform gnoj = new TranslateTransform();
            slava.RenderTransform = gnoj;
            DoubleAnimation animX = new DoubleAnimation(0, -200, TimeSpan.FromSeconds(1));
            gnoj.BeginAnimation(TranslateTransform.XProperty, animX);
            Random rnd = new Random();
            int poulrnd = rnd.Next(2);
            if (poulrnd == 0)
            {
                Properties.Settings.Default.count2 += 10;
                Properties.Settings.Default.Save();
                qwe2.Text = Properties.Settings.Default.count2.ToString();
                miss1.Volume = 1;
                miss1.Open(new Uri(@"C:\Users\ASUS\Desktop\for_clicker\podgotovka.wma", UriKind.Absolute));
                miss1.Play();
            }else{
                Properties.Settings.Default.count2 -= 10;
                Properties.Settings.Default.Save();
                qwe2.Text = Properties.Settings.Default.count2.ToString();
                miss1.Volume = 0.1;
                miss1.Open(new Uri(@"C:\Users\ASUS\Desktop\for_clicker\panchi.wma", UriKind.Absolute));
                miss1.Play();
            }
        }

        private void jhony_Click(object sender, RoutedEventArgs e)
        {
            gavno.Volume = 0.1;

            Properties.Settings.Default.count2 += 2;
            Properties.Settings.Default.Save();
            qwe2.Text = Properties.Settings.Default.count2.ToString();

            switch (k)
            {
                case 0:
                    gavno.Open(new Uri(@"C:\Users\ASUS\Desktop\for_clicker\govno.wma", UriKind.Absolute));
                    gavno.Play();
                    break;
                case 1:
                    gavno.Open(new Uri(@"C:\Users\ASUS\Desktop\for_clicker\zalupa.wma", UriKind.Absolute));
                    gavno.Play();
                    break;
                case 2:
                    gavno.Open(new Uri(@"C:\Users\ASUS\Desktop\for_clicker\penis.wma", UriKind.Absolute));
                    gavno.Play();
                    break;
                case 3:
                    gavno.Open(new Uri(@"C:\Users\ASUS\Desktop\for_clicker\her.wma", UriKind.Absolute));
                    gavno.Play();
                    break;
                case 4:
                    gavno.Open(new Uri(@"C:\Users\ASUS\Desktop\for_clicker\davalka.wma", UriKind.Absolute));
                    gavno.Play();
                    break;
                case 5:
                    gavno.Open(new Uri(@"C:\Users\ASUS\Desktop\for_clicker\hui.wma", UriKind.Absolute));
                    gavno.Play();
                    break;
                case 6:
                    gavno.Open(new Uri(@"C:\Users\ASUS\Desktop\for_clicker\blyadina.wma", UriKind.Absolute));
                    gavno.Play();

                    TranslateTransform jhon = new TranslateTransform();
                    jhony.RenderTransform = jhon;
                    DoubleAnimation animY = new DoubleAnimation(0, 186, TimeSpan.FromSeconds(1));
                    jhon.BeginAnimation(TranslateTransform.YProperty, animY);
                    k = -1;
                    break;
            }
            k++;
        }
        private void olegi_Click(object sender, RoutedEventArgs e)
        {
            {
                Properties.Settings.Default.count2 += 15;
                Properties.Settings.Default.Save();
                qwe2.Text = Properties.Settings.Default.count2.ToString();

                TranslateTransform qwer = new TranslateTransform();
                lsp.RenderTransform = qwer;
                DoubleAnimation animX = new DoubleAnimation(0, 700, TimeSpan.FromSeconds(2));
                qwer.BeginAnimation(TranslateTransform.XProperty, animX);
                DoubleAnimation animY = new DoubleAnimation(0, 500, TimeSpan.FromSeconds(2));
                qwer.BeginAnimation(TranslateTransform.YProperty, animY);

                gavno.Open(new Uri(@"C:\Users\ASUS\Desktop\for_clicker\nedoreperok.wma", UriKind.Absolute));
                gavno.Volume = 0.02;
                gavno.Play();


            }
        }
        private void porchy_Click(object sender, RoutedEventArgs e)
        {
            {

                gavno1.Open(new Uri(@"C:\Users\ASUS\Desktop\for_clicker\pozhileesh.wma", UriKind.Absolute));
                gavno1.Volume = 0.3;
                gavno1.Play();

                Properties.Settings.Default.count2 += 5;
                Properties.Settings.Default.Save();
                qwe2.Text = Properties.Settings.Default.count2.ToString();

                TranslateTransform pos = new TranslateTransform();
                porchy.RenderTransform = pos;
                DoubleAnimation animY = new DoubleAnimation(0, -160, TimeSpan.FromSeconds(1));
                pos.BeginAnimation(TranslateTransform.YProperty, animY);

            }
        }
        private void Bg1_Click(object sender, RoutedEventArgs e)
        {
            qwerty.ImageSource = new BitmapImage(new Uri(@"C:\Users\ASUS\Downloads\maxresdefault-3.jpg", UriKind.Relative));
            MessageBox.Show("Фон установлен");
        }

        private void Bg2_Click(object sender, RoutedEventArgs e)
        {
            if (Properties.Settings.Default.count >= 700)
            {
                qwerty.ImageSource = new BitmapImage(new Uri(@"C:\Users\ASUS\Downloads\b2.jpg", UriKind.Relative));
                MessageBox.Show("Фон установлен");
            }
            else
                MessageBox.Show("Набейте 700 кликов");
        }
        private void Bg3_Click(object sender, RoutedEventArgs e)
        {
            if (Properties.Settings.Default.count >= 700)
            {
                qwerty.ImageSource = new BitmapImage(new Uri(@"C:\Users\ASUS\Downloads\b3.jpg", UriKind.Relative));
                MessageBox.Show("Фон установлен");
            }
            else
                MessageBox.Show("Набейте 1703 кликов");
        }

        private void Bg4_Click(object sender, RoutedEventArgs e)
        {
            if (Properties.Settings.Default.count2 >= 1000)
            {
                qwerty.ImageSource = new BitmapImage(new Uri(@"C:\Users\ASUS\Downloads\b4.jpg", UriKind.Relative));
                MessageBox.Show("Фон установлен");
            }
            else
                MessageBox.Show("Набейте 1000 голден кликов");
        }
        private void Bt1_Click(object sender, RoutedEventArgs e)
        {

            bt1.Source = new BitmapImage(new Uri(@"C:\Users\ASUS\Desktop\Screenshot_155.png", UriKind.RelativeOrAbsolute));
            MessageBox.Show("Кнопка установлена");
        
         }

        private void Bt2_Click(object sender, RoutedEventArgs e)
        {
            if (Properties.Settings.Default.count >= 1000)
            {
                bt1.Source = new BitmapImage(new Uri(@"C:\Users\ASUS\Downloads\oxykit.png", UriKind.RelativeOrAbsolute));
                MessageBox.Show("Кнопка установлена");
            }else 
                MessageBox.Show("набейте 1000 кликов");
        }
        private void Bt3_Click(object sender, RoutedEventArgs e)
        {
            if (Properties.Settings.Default.count >= 2000)
            {
                bt1.Source = new BitmapImage(new Uri(@"C:\Users\ASUS\Downloads\bt3.png", UriKind.RelativeOrAbsolute));
                MessageBox.Show("Кнопка установлена");
            }
            else
                MessageBox.Show("набейте 2000 кликов");
        }
        
             private void Bt4_Click(object sender, RoutedEventArgs e)
        {
             if (Properties.Settings.Default.count2 >= 2000)
            {
                bt1.Source = new BitmapImage(new Uri(@"C:\Users\ASUS\Downloads\bt4.jpg", UriKind.RelativeOrAbsolute));
                MessageBox.Show("Кнопка установлена");
            }
            else
                MessageBox.Show("набейте 2000 голден кликов");
        }
    }
}
