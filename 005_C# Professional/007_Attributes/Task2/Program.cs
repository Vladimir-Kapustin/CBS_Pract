using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
	class Program
	{
		static void Main(string[] args)
		{
			TestClass test = new TestClass();

			test.OldMethod();				//метод отрабатывает, но выводит предупреждение в ErrorList с текстом, указанным в атрибуте
			test.NewMethod();
			test.OldMedhodWithError();		//метод может отработать, но и не отработать, если во 2-м аргументе атрибута obdolete будет указано true. Тогда в ErrorList будет выведена ошибка с текстом сообщения, указанным в атрибуте.
			test.EnotherNewMethod();
		}
	}
}
