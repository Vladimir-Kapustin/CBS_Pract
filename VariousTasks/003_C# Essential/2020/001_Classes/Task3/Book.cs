using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
	class Book
	{
		Title title;
		Author author;
		Content content;

		void InitializeBook ()
		{
			title = new Title();
			author = new Author();
			content = new Content();
		}

		public Book (string title, string author, string content)
		{
			InitializeBook();
			this.title.TitleContent = title;
			this.author.Name = author;
			this.content.ContentText = content;
		}

		//public Book() {}

		public void Show()
		{
			title.Show();
			author.Show();
			content.Show();
		}

		internal string Title
		{
			set { title.TitleContent = value; }
		}

		internal string Author
		{
			set { author.Name = value; }
		}

		internal string Content
		{
			set { content.ContentText = value; }
		}
	}
}
