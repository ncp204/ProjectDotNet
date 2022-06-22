using Source.beans;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
//using System.Drawing;

namespace Source
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Article> listArticles;

        public MainWindow()
        {


            listArticles = new List<Article>()
            {
                new Article("tit1 asdas","", new BitmapImage(new Uri("https://mysql.vi.downloadastro.com/wp-content/uploads/2022/06/mysql-110x84.jpeg"))),
                new Article("tit2 asdas","", new BitmapImage(new Uri("D:/Users/dtphu/source/repos/Project repo/Projectfinal/ProjectDotNet/ReadNews/ReadNews/assets/Not_found.jpg"))),
                new Article("tit3 asdas","", new BitmapImage(new Uri("D:/Users/dtphu/source/repos/Project repo/Projectfinal/ProjectDotNet/ReadNews/ReadNews/assets/Not_found.jpg"))),
                new Article("tit4 asdas","", new BitmapImage(new Uri("D:/Users/dtphu/source/repos/Project repo/Projectfinal/ProjectDotNet/ReadNews/ReadNews/assets/Not_found.jpg"))),
                new Article("tit5 asdas","", new BitmapImage(new Uri("D:/Users/dtphu/source/repos/Project repo/Projectfinal/ProjectDotNet/ReadNews/ReadNews/assets/Not_found.jpg"))),
                new Article("tit6 asdas","", new BitmapImage(new Uri("D:/Users/dtphu/source/repos/Project repo/Projectfinal/ProjectDotNet/ReadNews/ReadNews/assets/Not_found.jpg"))),
                new Article("tit7 asdas","", null)
            };

            InitializeComponent();

            this.ArBox.ItemsSource = listArticles;
        }

        private void UpbtAction(object sender, RoutedEventArgs e)
        {
            //scrMain.ScrollToHome();
        }

        private void ChangeColor_button(object sender, RoutedEventArgs e)
        {
            Button bt = (Button)sender;
            bt.Foreground = Brushes.Orange;
        }

        private void Button_MouseLeave(object sender, MouseEventArgs e)
        {
            Button bt = (Button)sender;
            bt.Foreground = Brushes.Blue;
        }
    }
}
