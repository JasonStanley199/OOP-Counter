using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CounterTest
{
    public class Counter
    {
        private int _count;
        private string _name;
        public Counter(string name)
        {
            _name = name;
            _count = 0;
        }

        public void Increment() //to increment .count by 1
        {
            _count = _count + 1;
        }

        public void Reset() //to reset .count to 0
        {
            _count = 0;
        }

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        public string Ticks
        {
            get
            {
                return _count.ToString();
            }
        }

        public int getCount()
        {
            return _count;
        }

    }

}
