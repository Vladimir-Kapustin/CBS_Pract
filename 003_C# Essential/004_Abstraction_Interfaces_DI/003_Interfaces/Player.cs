using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_Interfaces
{
    class Player : IPlayable, IRecordable
    {
        public void Play() { Console.WriteLine("Playing!!"); }
        void IPlayable.Pause() {Console.WriteLine("Playing is Paused!!");}
        void IPlayable.Stop() {Console.WriteLine("Playing Stopped!!");}

        public void Record() { Console.WriteLine("Recording!!"); }
        void IRecordable.Pause() {Console.WriteLine("Recording is Paused!!");}
        void IRecordable.Stop() {Console.WriteLine("Recording Stopped!!");}
    }
}
