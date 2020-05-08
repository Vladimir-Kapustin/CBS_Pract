using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _000_MVP
{
    class Model // Это модель из MVP - отсюда берутся все данные. (!) - здесь может быть заложена бизнес-логика
    {
        public string Logic(string s)
        {
            //if (s == "MVP")
            //{
            //    return string.Format("{0} is: шаблон проектирования пользовательского интерфейса, который был разработан для облегчения автоматического модульного тестирования и улучшения разделения ответственности в презентационной логике.", s);
            //}
            //else { return string.Format("Работа: Model.Logic({0}) !!!!!", s); }
            return string.Format("Работа: Model.Logic({0}) !!!!!", s);
        }
    }
}
