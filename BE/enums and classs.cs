using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{

    /// <summary>
    /// 
    /// </summary>
   public class number:IComparable
    {
        //-------------filds and proportis--------
        private string num;
        public string Num
        {
            get
            {
                return num;
            }

            set
            {
                try
                {
                    Convert.ToInt32(value);
                }
                catch (Exception)
                {
                    throw new Exception("It is not a number");
                }
                num = value;
            }
        }
        
        //-----------methods----------
        public override string ToString()
        {
            return Num;
        }
        public int CompareTo(object obj)
        {
            return Convert.ToUInt32(Num).CompareTo(obj);
        }

        //------------implicits-----------
        public static implicit operator number(int n)
        {
            return new number(n);
        }
        public static implicit operator number(string n)
        {
            return new number(n);
        }

        //------------constructors---------
        public number() { }
        public number(int num1)
        {
            Num = num1.ToString();
        }
        public number(string num1)
        {
            Num = num1;
        }
    }


    
    public class Work_Schedule
    {
        //-------------filds and proportis--------
        public bool works { get; set; }
        public DateTime start_hour { get; set; }
        public DateTime end_hour { get; set; }

        //------------constructors---------
        public Work_Schedule() { works = false; }
        public Work_Schedule(DateTime start, DateTime end, bool work = true)
        {
            start_hour = start;
            end_hour = end;
            works = work;
        }
    }
    
}
