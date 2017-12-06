using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
   

    public class Work_Schedule
    {
        
        public bool works { get; set; }
        public DateTime start_hour { get; set; }
        public DateTime end_hour { get; set; }
        public Work_Schedule() { works = false; }
        public Work_Schedule(DateTime start, DateTime end, bool work = true)
        {
            start_hour = start;
            end_hour = end;
            works = work;
        }
    }
    
}
