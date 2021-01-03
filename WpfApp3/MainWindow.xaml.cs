using System;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Media.Animation;


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
            switch (Properties.Settings.Default.count)
            {
                case 100:
                    MessageBox.Show("Интересный факт №1: В детстве оксимирон в школу вместо рюкзака брал мешок с полонием");
                    break;
                case 200:
                    MessageBox.Show("Интересный факт №2: В баттле Окси Гнойный Мирон выдал строку \"это средние рифмы правда? Ну и что ведь за ними правда\", многие подумали, что он плохо подготовился, но мастаки баттлрепа быстро поняли что это отсылка к легендарным строкам замая:\"Ха! Котик лижет яйца, будто новый Джордан. Я забиваю три в очко ему как новый Джордан!\"");
                    break;
                case 300:
                    MessageBox.Show("Интересный факт №3: До того как попасть в \"Оксфорд\" оксимирон с десяти лет учился в университете \"Куни\"");
                    break;
                case 400:
                    MessageBox.Show("Интересный факт №4: Оксимирон отказался сосать Лимонову за 15 лимонов, потому что лимоны кислые пиздец");
                    break;
                case 500:
                    MessageBox.Show("Интересный факт №5: В 2008 году Оксимирон жил со своей женой Соней Грезе в однокомнатной конуре, бедность прошла, но их любовь все так же сильна, РЕСПЕКТ!");
                    break;
                case 600:
                    MessageBox.Show("Интересный факт №6: Оксимирон настолько тру, что отшивал даже \"Вечерний Ургант\",РЕСПЕКТ!!");
                    break;
                case 700:
                    MessageBox.Show("Интересный факт №7: 24.09.2017 в 17:03 Оксимирон поставил лайк на пост в сообществе \"Абстрактные мемы про антихайп культуру\"(паблик хуйня кста (МПА в фаворитах)) после чего в 17:23 вероломно убрал лайк с поста,\n это был не первый случай, до этого оксимирон убирал лайк с клипа Замая. ДИЗРЕСПЕКТ!!! больше инфы - https://clck.ru/ShZvv");
                    break;
                case 800:
                    MessageBox.Show("Анекдот №1: Идет бабка по базару. Видит - кепочка! \nПодходит к продавцу и спрашивает:\n— А что это за кепочка ?\n— Это кепка из оксишопа.\n— Ну и сам её носи, чепушила!");
                    break;
                case 900:
                    MessageBox.Show("Анекдот №2: Мужик попадает в ад. Ему говорят \n— Ты не сильно нагрешил поэтому мы разрешаем выбрать себе пытку самостоятельно.\nПроходит в первую комнату, а там жарят людей на сковороде.Ему не подходит и он уходит.\nВо второй комнате иголки под кожу вставляют.\n— Это тоже больно, -говорит он и уходит.\nВ третьей комнате стоят мужики по колено в говне и курят.\n— Вот это по мне, хоть и воняет, наверно лучшего нет.\nВстаёт в говно.Достаёт сигарету, закуривает.\nИ тут ему:\n— Все, перекур окончен, включаем Горгород!");
                    break;
                case 1000:
                    MessageBox.Show("Анекдот №3: По длинной, дикой, утомительной дороге шел Мирон Янович с Томасом Мразом.\nШел он себе шел, устал, Томас Мраз тоже устал.Вдруг перед ними - оазис!\nПрекрасные ворота, за оградой - музыка, цветы, журчание ручья,\nсловом, отдых.\n- Что это такое ? -спросил Мирон Янович у привратника.\n- Это рай, ты уже умер, и теперь можешь войти и отдохнуть по - настоящему.\n- А есть там вода ?\n-Сколько угодно: чистые фонтаны, прохладные бассейны...\n-А поесть дадут ?\n-Все, что захочешь.\n- Но со мной Томас Мраз.\n- Сожалею, сэр, с Томасом Мразом нельзя.Его придется оставить здесь.\n- Ну и нахуй его! - сказал Мирон Янович и зашёл в рай");
                    break;
                case 1100:
                    MessageBox.Show("Анекдот №4: Сидят Мирон Янович, Томас Мраз и Дизастер в кинотеатре. Томас Мраз говорит:\n— Смотри Мирон мастурбирует!\n— Да не обращай внимания.\n— Не могу, он делает это моей рукой.");
                    break;
                case 1200:
                    MessageBox.Show("Анекдот №5: После шоу в Олимпийском сидят в грмёрке Органик и Мирон Янович и тут Органик задумчиво спрашивает:\n— Мирон Янович.а что это за масочка на Порчи ?\n— Да б - р - р - р - р - р - р - ять! - разъярился выбляденно Мирон Янович. - Сколько раз тебе повторять: Масочка - у Охры! А у Порчи ебальник такой стрёмный.");
                    break;
                case 1300:
                    MessageBox.Show("Анекдот №6: Созвал Мирон Янович всех рэперов и говорит:\nКто спрыгнет с воо - о - он той высокой горы, тот может мой хайп забрать.\nРэперы залезли на гору - бляяя! страшно!\nА Мирон Янович встал внизу и ждет.\nЖдет, ждет, вдруг какая - то точка оторвалась и вниз полетела.Увеличилась, хуяк! — Слава КПСС упал, и сразу обратно полез.\nМирон Янович и говорит:\n— Куда, Слава ? Забирай хайп! \nА тот лезет и лезет вверх:\n— Я лучше сдохну ебучем ноунеймом, чем прославлюсь и стану тобой! ");
                    break;
                case 1500:
                    MessageBox.Show("Анекдот №7: Летят в самолёте Мирон Янович, Дизастер и Органик. Диз решает понтануться, высовывает руку в иллюминатор, достаёт обратно, смотрит на неё и говорит:\n— Над США летим, над Лос - Анджелесом, рука загорела немного.\nОрганик позже суёт руку наружу, достаёт, нюхает и вещает:\n— Над Канадой летим, рука хвоей пахнет.\nОкси, в свою очередь, выставляет за борт руку, потом смотрит на неё и говорит:\n— Над E-16 летим, часы спиздили.");
                    break;
                case 1703:
                    Window1703 window1703 = new Window1703();
                    window1703.Show();
                    break;
                    
            }
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
