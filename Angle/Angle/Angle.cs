using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngleProj
{
    class Angle
    {
        public int Degrees { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }
        public long AbsoluteSeconds { get { return Degrees * 3600 + Minutes * 60 + Seconds; } }

        public Angle(int degrees = 0, int minutes = 0, int seconds = 0)
        {
            Degrees = Math.Abs(degrees);
            Minutes = Math.Abs(minutes);
            Seconds = Math.Abs(seconds);
            //AbsoluteSeconds = Degrees * 3600 + Minutes * 60 + Seconds;

            this.Customize();
        }
        public Angle(Angle angle)
        {
            Degrees = Math.Abs(angle.Degrees);
            Minutes = Math.Abs(angle.Minutes);
            Seconds = Math.Abs(angle.Seconds);
            //AbsoluteSeconds = Degrees * 3600 + Minutes * 60 + Seconds;
        }

        private void Customize()
        {
            if (Seconds > 0)
            {
                Minutes = Minutes + Seconds / 60;
                Seconds = Seconds % 60;
            }
            if (Minutes > 60)
            {
                Degrees = Degrees + Minutes / 60;
                Minutes = Minutes % 60;
            }
            if (Degrees > 360)
            {
                Degrees = Degrees % 360;
            }
        }


        public override string ToString()
        {
            return string.Format("{0}°, {1}\', {2}\"", Degrees, Minutes, Seconds);
        }
        public static Angle operator +(Angle firstObj, Angle secondObj)
        {
            Angle result = new Angle(firstObj);

            result.Degrees += secondObj.Degrees;
            result.Minutes += secondObj.Minutes;
            result.Seconds += secondObj.Seconds;
            result.Customize();

            return result;
        }

        public static Angle operator -(Angle first, Angle second)
        {
            Angle result = new Angle(first);

            result.Degrees = Math.Abs(first.Degrees - second.Degrees);
            result.Minutes = Math.Abs(first.Minutes - second.Minutes);
            result.Seconds = Math.Abs(first.Seconds - second.Seconds);

            result.Customize();
            return result;
        }

        public static bool operator ==(Angle first, Angle second)
        {
            if ((first.AbsoluteSeconds - second.AbsoluteSeconds) == 0)
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(Angle first, Angle second)
        {
            if (first == second)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool operator >(Angle first, Angle second)
        {
            if ((first.AbsoluteSeconds - second.AbsoluteSeconds) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator <(Angle first, Angle second)
        {
            if ((first.AbsoluteSeconds - second.AbsoluteSeconds) < 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
