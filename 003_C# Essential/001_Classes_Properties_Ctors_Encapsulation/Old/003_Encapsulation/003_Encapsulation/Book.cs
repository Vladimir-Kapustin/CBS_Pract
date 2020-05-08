using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_Encapsulation
{
    class Book
    {
        Title title = null;
        Author author = null;
        Content content = null;

        public Book (string title)
        {
            InitializeBook();
            this.title.Title1 = title;
        }
        void InitializeBook ()
        {
            this.title = new Title(); 
            this.author = new Author();
            this.content = new Content();
        }

        public string Author
        {
            set
            {
                this.author.Author1 = value;
            }
        }

        public string Content
        {
            set
            {
                this.content.Content1 = value;
            }
        }
        public void Show ()
        {
            title.Show(); 
            author.Show();
            content.Show();
        }
            
    }
}
