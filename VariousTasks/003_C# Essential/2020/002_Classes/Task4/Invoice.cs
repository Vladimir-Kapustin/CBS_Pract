using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
	class Invoice
	{
		readonly int account;
		readonly string customer, provider;		//readonly-поля можно не делать закрытыми - они ж и так readonly! Их нет необходимости скрывать, чтоб защитить от изменения! Можно поставить public. По факту к ним мы уже обращаемся, как будто к свойствам только для чтения, которые в свою очередь обращаются к закрытым полям. Т.е. readonly-поля уже как будто инкапсулированы. И, соответственно, открытые свойства к ним можно не создавать

		string article;							//если задача - создать закрытые поля, можно сразу ставить автосвойства. Ведь ты ж и так к закрытым полям поставишь свойства для доступа!
		double quantity;

		public Invoice(int account, string customer, string provider)
		{
			this.account = account;
			this.customer = customer;
			this.provider = provider;
		}

		public string Article
		{
			get { return article; }
			set { article = value; }
		}

		public double Quantity
		{
			get { return quantity; }
			set { quantity = value; }
		}

		public int Account
		{													   // Вот эти все свойства можно поубирать. См. выше.
			get { return account; }							   // Вот эти все свойства можно поубирать. См. выше.
		}													   // Вот эти все свойства можно поубирать. См. выше.
															   // Вот эти все свойства можно поубирать. См. выше.
		public string Customer								   // Вот эти все свойства можно поубирать. См. выше.
		{													   // Вот эти все свойства можно поубирать. См. выше.
			get { return customer; }						   // Вот эти все свойства можно поубирать. См. выше.
		}													   // Вот эти все свойства можно поубирать. См. выше.
															   // Вот эти все свойства можно поубирать. См. выше.
		public string Provider								   // Вот эти все свойства можно поубирать. См. выше.
		{													   // Вот эти все свойства можно поубирать. См. выше.
			get { return provider; }						   // Вот эти все свойства можно поубирать. См. выше.
		} 													   // Вот эти все свойства можно поубирать. См. выше.

		public double VATCalculator(bool vat)
		{
			if (vat)
			{
				return 1000d * Quantity;
			}
			else
			{
				return ((1000d - (1000d / 6)))*Quantity;
			}
		}
	}
}
