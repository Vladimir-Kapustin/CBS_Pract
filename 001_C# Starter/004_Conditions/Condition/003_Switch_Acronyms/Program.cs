using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condition
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----Расшифровщик акронимов .NET-----");
            Console.WriteLine("Введите аббревиатуру или акроним");
            string acronym = Console.ReadLine().ToLower();

            switch (acronym)
            {
                case "clr":
                    Console.WriteLine("CLR: Common Language Runtime – Общеязыковая исполняющая среда\n– компонент пакета Microsoft .Net, исполняющий программы, написанные на .Net\nсовместимых языках программирования. (Путь к файлу CLR: C:\\Windows\\System32\n\\mscoree.dll )");
                    break;
                case "cls":
                    Console.WriteLine("CLS: Common Language Specification – Общеязыковая спецификация \nнабор правил описывающих функциональные возможности, которые должен поддерживать\n каждый отдельно взятый .Net-компилятор, чтобы генерировать программный код, который мог бы\nвыполняться CLR.");
                    break;
                case "cli":
                    Console.WriteLine("CLI: Common Language Infrastructure \n– спецификация общеязыковой инфраструктуры. Текущая версия CLI 3.5 (2007 год). CLI определяет архитектуру \nисполняющей среды CLR, сервисы, предоставляемые CLR выполняемым программам, классы \nпредоставляемые библиотекой FCL, а также реализующие общие правила CTS и CLS. ");
                    break;
                case "cil":
                    Console.WriteLine("CIL: (MSIL/IL) Common Intermediate Language \nпромежуточный язык для платформы .Net. Старое название MSIL (Microsoft Intermediate Language) \nизменено для создания стандарта ECMA-335. CIL – по синтаксису и мнемонике напоминает язык \nAssembler. CIL – можно рассматривать как assembler виртуальной машины .Net");
                    break;
                case "msil":
                    Console.WriteLine("MSIL: Microsoft Intermediate Language\nСтарое название для CIL, которое изменено для создания стандарта ECMA-335");
                    break;
                case "il":
                    Console.WriteLine("IL: Intermediate Language\n- Ещё одно сокращённое название CIL (Common Intermediate Language)");
                    break;
                case "gc":
                    Console.WriteLine("GC: Garbage Collector – Сборщик мусора\n- механизм автоматического управления памятью. GC – периодически освобождает память, удаляя из нее объекты, \nкоторые уже не будут востребованы приложением – иначе говоря, производит \nсборку мусора.");
                    break;
                case "jit":
                    Console.WriteLine("JIT: Just-in-time compilation\n - технология увеличения производительности .Net, путем компиляции байт-кода в машинный код непосредственно во время \nработы программы.");
                    break;
                case "asp":
                    Console.WriteLine("ASP: ASP.NET (Active Server Pages)\n— технология создания веб-приложений и веб-сервисов. ASP.NET имеет преимущество в скорости по сравнению с другими \nтехнологиями, основанными на скриптах. В ASP.NET можно работать с любым \n.NET языком.");
                    break;
                case "ado":
                    Console.WriteLine("ADO: ADO.NET (ActiveX Data Objects .NET)\n— основная модель доступа и работы с данными и базами данных для приложений, основанных на Microsoft .NET.");
                    break;
                case "wcf":
                    Console.WriteLine("WCF: Windows Communication Foundation\n— технология, которая используется для осуществления обмена данными между приложениями. WCF обеспечивает \nвсеобъемлющий контроль функций отправки сообщений приложения.");
                    break;
                case "wpf":
                    Console.WriteLine("WPF: Windows Presentation Foundation\n— технология .NET, которая используется для построения клиентских \n(настольных) приложений Windows с визуально привлекательными возможностями \nвзаимодействия с пользователем. Приложения WPF используют аппаратное \nускорение графики через DirectX, и являются более производительными и \nграфически привлекательными, чем аналогичные приложения реализованные \nс помощью технологии Windows Forms.");
                    break;
                case "wwf":
                    Console.WriteLine("WWF: Windows Workflow Foundation (WF)\n- технология компании Microsoft для определения, выполнения и управления рабочими процессами.");
                    break;
                case "xna":
                    Console.WriteLine("XNA: Microsoft XNA\n– технология, которая содержит набор инструментов с управляемой средой времени \nвыполнения (.NET), которая облегчает разработку и управление компьютерными играми.");
                    break;
                case "linq":
                    Console.WriteLine("LINQ: Language Integrated Query\n—  технология, которая позволяет создавать выражения запросов, применять их к ряду \nразличных целевых объектов из баз данных или хранилищ и тем самым манипулировать полученными значениями.");
                    break;
                case ".net":
                    Console.WriteLine(".NET: .NET Framework\n— программная платформа, основой которой является исполняющая \nсреда Common Language Runtime (CLR), способная выполнять различные программы, \nнаписанные не только на С#, но и на других (совместимых) языках программирования.");
                    break;
                default:
                    Console.WriteLine("No such abbreviation. Try again.");
                    break;
            }
            Console.ReadKey();
        }
    }
}
