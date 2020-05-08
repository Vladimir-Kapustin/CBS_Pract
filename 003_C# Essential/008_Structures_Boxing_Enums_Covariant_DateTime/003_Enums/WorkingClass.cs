using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_Enums
{
    class WorkingClass
    {
        Accauntant accauntant = new Accauntant();

        string position;
        int hours;

        public void DeterminePremium()
        {
            object element = Enum.Parse(typeof(Post), position);
            Post employee = (Post)element;

            if (accauntant.AskForBonus(employee, hours))    //В условном операторе производится вызов метода AskForBonus
            {
                Console.WriteLine("Premium is available");  //Отработает если метод AskForBonus вернет true
            }
            else
            {
                Console.WriteLine("Premium is not available");
            }
        }

        public WorkingClass(string position, int hours)
        {
            this.position = position;
            this.hours = hours;
        }
    }
}
