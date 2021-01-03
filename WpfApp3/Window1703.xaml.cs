using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Threading;

namespace WpfApp3
{
    /// <summary>
    /// Логика взаимодействия для Window1703.xaml
    /// </summary>
    public partial class Window1703 : Window
    {
        DispatcherTimer timer;
        public Window1703()
        {
            InitializeComponent();
            timer = new DispatcherTimer();
            media1703.Source = new Uri("C:\\Users\\ASUS\\Desktop\\for_clicker\\1703.mp4");
            media1703.LoadedBehavior = MediaState.Manual;
            media1703.UnloadedBehavior = MediaState.Manual;
            media1703.Volume = 1;
            media1703.Play();
        }
    }
}
