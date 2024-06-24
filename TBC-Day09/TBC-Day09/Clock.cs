using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBC_Day09
{
    public class Clock
    {
        public int _hours;
        public int _minutes;
        public int _seconds;
        public int Hours
        {
            get { return _hours; }
            set { _hours = value; }
        }
        public int Minutes
        {
            get { return _minutes; }
            set { _minutes = value; }
        }

        public int Seconds
        {
            get { return _seconds; }
            set { _seconds = value; }

        }
        public void DisplayTime()
        {
            Console.WriteLine($"Current Time: {Hours:D2}:{Minutes:D2}:{Seconds:D2}");
        }
        public bool SetTime(int hours, int minutes, int second)
        {
            if (hours < 0 || hours > 23 || minutes < 0 || minutes > 59 || second < 0 || Seconds > 59)
            {
                return false;
            }
            Hours = hours;
            Minutes = minutes;
            Seconds = second;
            return true;
        }
        public void increaseTime()
        {
            Seconds++;
            if (Seconds >= 60)
            {
                Seconds = 0;
                Minutes++;
            }
            if (Minutes >= 60)
            {
                Minutes = 0;
                Hours++;
            }
            if (Hours >= 24)
            {
                Hours = 0;

            }
        }


    }
}
