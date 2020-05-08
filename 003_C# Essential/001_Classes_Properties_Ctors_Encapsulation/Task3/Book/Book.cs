using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Book
    {
        Title title = null;
        Author author;          //для ссылочных объектов значение по умолчанию и так null, так что его можно нигде не указывать.
        Content content;

        public Book (string title, string Author, string content)
        {
            InitializeBook();
            this.title.Content = title;
            this.author.Content = Author;
            this.content.Text = content;
        }
        
        void InitializeBook ()
        {
            this.title = new Title(); 
            this.author = new Author();
            this.content = new Content();
        }

        //public string Author                  // Это первоначальный вариант. И он похож на пример в видео (в примерах). Здесь же я переношу установку этих значений в работу к-ра. Хотя Рекомендуется обычно минимизировать его работу (поэтому, наверное, они там в уроке делают правильнее).
        //{
        //    set
        //    {
        //        this.author.Content = value;
        //    }
        //}

        //public string Content
        //{
        //    set
        //    {
        //        this.content.Text = value;
        //    }
        //}
        
        public void Show ()
        {
            title.Show(); 
            author.Show();
            content.Show();
        }
            
    }
}
