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
        private string title;
        private string content;
        private BitmapImage image;

        public Article(string title, string content, BitmapImage image)
        {
            this.title = title;
            this.content = content;
            this.image = image;
        }

        public string Title { get => title; set => title = value; }
        public string Content { get => content; set => content = value; }
        public BitmapImage Image { get => image; set => image = value; }
    }
}
