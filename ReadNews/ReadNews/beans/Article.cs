using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace Source.beans
{
    internal class Article
    {
        private int id;
        private string title;
        private string content;
        private BitmapImage image;

        public Article(int id,string title, string content, BitmapImage image)
        {
            this.title = title;
            this.content = content;
            this.image = image;
            this.id = id;
        }

        
        public int ID { get => id; set => id = value; }
        public string Title { get => title; set => title = value; }
        public string Content { get => content; set => content = value; }
        public BitmapImage Image { get => image; set => image = value; }
    }
}
