using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CounterTest;

namespace ClockTest
{
    public class Clock
    {
        private Counter _hours;
        private Counter _minutes;
        private Counter _seconds;

        public Clock()
        {
            _hours = new Counter("Hours");
            _minutes = new Counter("Minutes");
            _seconds = new Counter("Seconds");
        }

        public void Tick()
        {
            if (_seconds.getCount() < 59)
            {
                _seconds.Increment();
            }
            else
            {
                _seconds.Reset();
                if (_minutes.getCount() < 59)
                {
                    _minutes.Increment();
                }
                else
                {
                    _minutes.Reset();
                    if (_hours.getCount() == 23)
                    {
                        _hours.Reset();
                    }
                    else
                    {
                        _hours.Increment();
                    }
                }
            }
        }

        public string ReadTime()
            {
                return string.Format("{0}:{1:00}:{2:00}", _hours, _minutes, _seconds);
            }
   
           

        public int Hour { get => _hours.getCount(); }
        public int Minute { get => _minutes.getCount(); }
        public int Second { get => _seconds.getCount(); }

        public void Reset()
        {
            _seconds.Reset();
            _minutes.Reset();
            _hours.Reset();
        }
    }
}
