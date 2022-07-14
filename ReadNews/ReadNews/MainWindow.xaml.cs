using Source.beans;
using System;
using System.Collections;
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
        ArrayList listArticles;

        public MainWindow()
        {


            //listArticles = new ArrayList()
            //{
            //   new Article(1,"tit1 asdas","", new BitmapImage(new Uri("https://mysql.vi.downloadastro.com/wp-content/uploads/2022/06/mysql-110x84.jpeg"))),
            //   new Article(2,"tit2 asdas","", new BitmapImage(new Uri("https://mysql.vi.downloadastro.com/wp-content/uploads/2022/06/mysql-110x84.jpeg"))),
            //   new Article(3,"tit3 asdas","", new BitmapImage(new Uri("https://mysql.vi.downloadastro.com/wp-content/uploads/2022/06/mysql-110x84.jpeg"))),
            //   new Article(4,"tit4 asdas","", new BitmapImage(new Uri("https://mysql.vi.downloadastro.com/wp-content/uploads/2022/06/mysql-110x84.jpeg"))),
            //};

            InitializeComponent();
            listArticles =  ReadNews.service.DetailService.getListNews();
            this.ArBox.ItemsSource = listArticles;

            MessageBox.Show(listArticles.Count + "");
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

        private void ClickToDetail(object sender, RoutedEventArgs e)
        {
            Button bt = (Button)sender;
            //String a = sender.;
            MessageBox.Show(listArticles.Count + "");
        }

        private void ListViewItem_PreviewMouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            //ArBox.SelectedItems.Clear();

            //ListViewItem item = sender as ListViewItem;
            //if (item != null)
            //{
            //    item.IsSelected = true;
            //    ArBox.SelectedItem = item;
            //}
        }

        private void ListViewItem_PreviewMouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            ListViewItem item = sender as ListViewItem;
            if (item != null && item.IsSelected)
            {
                MessageBox.Show(item.Name);
            }
        }

        private void Button_MouseLeave(object sender, RoutedEventArgs e)
        {

        }
    }
}
