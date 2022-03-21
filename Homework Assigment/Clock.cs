using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Assigment
{
    public class Clock
    {
        private int hour;
        private int minute;
        public int Hour
        {
            get
            {
                return hour;
            }
            set
            {
                if (value < 0 || value > 12)
                {
                    throw new ArgumentException("Hour value is not valid!");
                }
                hour = value;
            }
        }
        public int Minute
        {
            get
            {
                return minute;
            }
            set
            {
                if (value < 0 || value > 60)
                {
                    throw new ArgumentException("Minute value is not valid!");
                }
                if (value == 60)
                {
                    Hour++;
                    value -= 60;
                }
                minute = value;
            }
        }

        public Clock(int hour, int minute)
        {
            this.Hour = hour;
            this.Minute = minute;
        }

        public double CalculateAngle()
        {
            int hour_angle = (int)(0.5 * (Hour * 60 + Minute));
            int minute_angle = 6 * Minute;

            int clock_angle = Math.Abs(hour_angle - minute_angle);

            return Math.Min(360 - clock_angle, clock_angle);
        }
    }
}
