using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadNews.beans
{
    internal class DetailNews
    {
        private int id;
        private string title;
        private string content;
        private string imageUrl;
        private string dateAdd;
        private string author;

        public DetailNews(int id, string title, string content, string imageUrl, string dateAdd, string author)
        {
            this.Id = id;
            this.Title = title;
            this.Content = content;
            this.ImageUrl = imageUrl;
            this.DateAdd = dateAdd;
            this.Author = author;
        }

        public int Id { get => id; set => id = value; }
        public string Title { get => title; set => title = value; }
        public string Content { get => content; set => content = value; }
        public string ImageUrl { get => imageUrl; set => imageUrl = value; }
        public string DateAdd { get => dateAdd; set => dateAdd = value; }
        public string Author { get => author; set => author = value; }
    }
}
