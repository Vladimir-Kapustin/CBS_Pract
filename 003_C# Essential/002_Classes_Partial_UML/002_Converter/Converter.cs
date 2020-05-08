using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_Converter
{
    class Converter     //--Работает - Супер! Но отличие от старого варианта - что надо внимательнее изучать ТЗ: там не было сказано, что должны быть конвертации между евро, долларом и рублём. Там сказано только, что конвертация должна быть из гривны или в гривну из указанных валют.
    {
        //Fields
        double courseUsd, courseEur, courseRub, sum;
        string val, convertedVal;

        //Ctor
        public Converter(double courseUsd, double courseEur, double courseRub, string val, double sum, string convertedVal)
        {
            this.courseUsd = courseUsd;
            this.courseEur = courseEur;
            this.courseRub = courseRub;
            this.val = val;
            this.sum = sum;
            this.convertedVal = convertedVal;
        }

        public Converter() { }

        #region Метод конвертации
        public void Convert()
        {
            switch (val)
            {
                case "uah":
                    ConvertUah();
                    break;
                case "usd":
                    ConvertUsd();
                    break;
                case "eur":
                    ConvertEur();
                    break;
                case "rub":
                    ConvertRub();
                    break;
                default:
                    Console.WriteLine("Вы неправильно ввели исходную валюту, попробуйте ещё раз.");
                    break;
            }
        }
        #endregion

        #region Конвертация гривны во все валюты
        private void ConvertUah()
        {
            switch (convertedVal)
            {
                case "usd":
                    Console.WriteLine("{0} {1} = {2} {3}", sum, val.ToUpper(), Math.Round(sum / courseUsd, 2), convertedVal.ToUpper());
                    break;
                case "eur":
                    Console.WriteLine("{0} {1} = {2} {3}", sum, val.ToUpper(), Math.Round(sum / courseEur, 2), convertedVal.ToUpper());
                    break;
                case "rub":
                    Console.WriteLine("{0} {1} = {2} {3}", sum, val.ToUpper(), Math.Round(sum / courseRub, 2), convertedVal.ToUpper());
                    break;
                default:
                    Console.WriteLine("Вы неправильно ввели валюту конвертации");
                    break;
            }
        }
        #endregion

        #region Конвертация доллара во все валюты
        private void ConvertUsd()
        {
            switch (convertedVal)
            {
                case "uah":
                    Console.WriteLine("{0} {1} = {2} {3}", sum, val.ToUpper(), Math.Round(sum * courseUsd, 2), convertedVal.ToUpper());
                    break;
                case "eur":
                    Console.WriteLine("{0} {1} = {2} {3}", sum, val.ToUpper(), Math.Round(sum * courseUsd / courseEur, 2), convertedVal.ToUpper());
                    break;
                case "rub":
                    Console.WriteLine("{0} {1} = {2} {3}", sum, val.ToUpper(), Math.Round(sum * courseUsd / courseRub, 2), convertedVal.ToUpper());
                    break;
                default:
                    Console.WriteLine("Вы неправильно ввели валюту конвертации");
                    break;
            }
        }
        #endregion

        #region Конвертация евро во все валюты
        private void ConvertEur()
        {
            switch (convertedVal)
            {
                case "uah":
                    Console.WriteLine("{0} {1} = {2} {3}", sum, val.ToUpper(), Math.Round(sum * courseEur, 2), convertedVal.ToUpper());
                    break;
                case "usd":
                    Console.WriteLine("{0} {1} = {2} {3}", sum, val.ToUpper(), Math.Round(sum * courseEur / courseUsd, 2), convertedVal.ToUpper());
                    break;
                case "rub":
                    Console.WriteLine("{0} {1} = {2} {3}", sum, val.ToUpper(), Math.Round(sum * courseEur / courseRub, 2), convertedVal.ToUpper());
                    break;
                default:
                    Console.WriteLine("Вы неправильно ввели валюту конвертации");
                    break;
            }
        }
        #endregion

        #region Конвертация рубля во все валюты
        private void ConvertRub()
        {
            switch (convertedVal)
            {
                case "uah":
                    Console.WriteLine("{0} {1} = {2} {3}", sum, val.ToUpper(), Math.Round(sum * courseRub, 2), convertedVal.ToUpper());
                    break;
                case "usd":
                    Console.WriteLine("{0} {1} = {2} {3}", sum, val.ToUpper(), Math.Round(sum * courseRub / courseUsd, 2), convertedVal.ToUpper());
                    break;
                case "eur":
                    Console.WriteLine("{0} {1} = {2} {3}", sum, val.ToUpper(), Math.Round(sum * courseRub / courseEur, 2), convertedVal.ToUpper());
                    break;
                default:
                    Console.WriteLine("Вы неправильно ввели валюту конвертации");
                    break;
            }
        }
        #endregion
    }
}
