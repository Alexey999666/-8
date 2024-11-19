using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lib_14
{

    
    public class Prime : ISeries, IComparable, ICloneable
    {
        private int _start;
        public int Start
        {
            get { return _start; }
            set { if (value > 0) _start = value; }

        }
        private int _val;
        public int val
        {
            get { return _val; }
            set { if (value > 0) _val = value; }
        }
        public Prime()
        {

            Start = 1;
            val = 1;
        }

        public int GetNext()
        {
            val++;
            while (!IsPrime(val))
            {
                val += 1;
            }
            return val;
        }
        public bool IsPrime(int num)
        {
            if (num <= 1) return false;
            for (int i = 2; i * i <= num; i++)
            {
                if (num % i == 0) return false;
            }
            return true;
        }

        public void Reset()
        {
            val = Start;
        }
        public void SetStart(int startNumber)
        {
            if (startNumber > 1) Start = startNumber;

        }
        public int CompareTo(object obj)
        {
            Prime prime = (Prime)obj;
            if (this.val > prime.val) return 1;
            if (this.val < prime.val) return -1;
            return 0;
        }
        public object Clone()
        {
            Prime prime = new Prime();
            prime.Start = this.Start;
            prime.val = this.val;
            return prime;
        }
    }

}


