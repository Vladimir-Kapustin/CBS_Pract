using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_Inherit_Polymor_Aggreg               // как я и подумал - можно и с массивами
{
    class ClassRoom
    {
        Pupil pupil1 = new BadPupil("Ivan");
        Pupil pupil2;
        Pupil pupil3;
        Pupil pupil4 = new GoodPupil("Alena");
        
        public ClassRoom (Pupil pupil2, Pupil pupil3)
        {
            this.pupil2 = pupil2;
            this.pupil3 = pupil3;
        }

        public ClassRoom(Pupil pupil1, Pupil pupil2, Pupil pupil3)
        {
            this.pupil1 = pupil1;
            this.pupil2 = pupil2;
            this.pupil3 = pupil3;
        }
        public void Show ()
        {
            pupil1.Print();
            pupil2.Print();
            pupil3.Print();
            pupil4.Print();
        }
    }
}
