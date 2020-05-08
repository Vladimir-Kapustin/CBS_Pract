using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Article
    {
        string productName;
        string storeName;
        int price;

        public string ProductName           //Здесь не обязательно было инкапсулировать поля. Можно было просто поставить автоматические свойства.
        {
            get { return productName; }
            set { productName = value; }
        }

        public string StoreName
        {
            get { return storeName; }
            set { storeName = value; }
        }

        public int Price
        {
            get { return price; }
            set { price = value; }
        }

    }
}
