using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_Converter    //Конечно, кривенько, но отличие от нового способа - во-первых ПОЛНОСТЬЮ отвечает ТЗ, во-вторых минимализм, в третьих соответствует идее ответов авторов на домашние задания.
{
    class ConverterOld
    {
        double usd;
        double eur;
        double rub;
        double sumUah;
        double sumUsd;

        public double SumUsd
        {
            get { return sumUsd; }
            set { sumUsd = value; }
        }
        double sumEur;
        double sumRub;

        public double SumUah
        {
            get { return sumUah; }
            set { sumUah = value; }
        }

        public ConverterOld(double usd, double eur, double rub)
        {
            this.usd = usd;
            this.eur = eur;
            this.rub = rub;
        }
        public void ShowUSD()
        {
            Console.WriteLine("{0} USD", Math.Round(sumUah / usd, 2));
        }
        public void ShowEUR()
        {
            Console.WriteLine("{0} EUR", Math.Round(sumUah / eur, 2));
        }
        public void ShowRUB()
        {
            Console.WriteLine("{0} RUB", Math.Round(sumUah / rub, 2));
        }
        public void ShowUahUsd()
        {
            Console.WriteLine("{0} UAH", Math.Round(sumUsd * usd, 2));
        }
        public void ShowUahEur()
        {
            Console.WriteLine("{0} UAH", Math.Round(sumEur * eur , 2));
        }
        public void ShowUahRub()
        {
            Console.WriteLine("{0} UAH", Math.Round(sumRub * rub, 2));
        }
    }
}
