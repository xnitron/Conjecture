using CollarzConjecture.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollarzConjecture
{
    public class Model : Observable
    {
        private int _counter;
        public int Counter
        {
            set { _counter = 0; }
            get { return _counter; }
        }

        public int Conjecture(int number)
        {
            while (number != 1)
            {
                if ((number % 2) == 0)
                {
                    number /= 2;
                }
                else
                {
                    number = number * 3 + 1;
                }
                    _counter++;
            }

            return Counter;
        }

        public void GetCounter(int num)
        {
            Conjecture(num);
            NotifyObservers();
        }

    }
}
