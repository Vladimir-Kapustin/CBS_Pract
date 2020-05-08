using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task0_Improved
{
	class Program		//--пример, я б не сказал, что лучше предыдущего. Он сделан по мотивам ответов к домашним заданиям. Вроде в задании предполагалось, что при приведении типов должен меняться и цвет. Т.е. можно использовать либо виртуальные методы, либо замещение. Но в ответах ничего такого нет. Там как бы "железно" не сказано, что изменение цветов должно происходить именно при приведении - так что содержанию задания ответ вроде не противоречит :).
	{
		static void Main(string[] args)
		{
			DerivedPrinter derivedPrinter = new DerivedPrinter(ConsoleColor.Blue);
			derivedPrinter.Print("hello");

			Printer scndPrinter = derivedPrinter;
			scndPrinter.Print("Hello");

			Printer printer = new Printer(ConsoleColor.DarkGreen);
			printer.Print("hello");
		}
	}
}
