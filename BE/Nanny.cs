using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{

    public class Nanny
    {
        //------------proportis and fields----------
        public readonly string ID;
        public string first_name { get; set; }
        public string last_name { get; set; }
        public DateTime date_of_birth { get; set; }
        public string phone_number { get; set; }
        public string address { get; set; }
        public bool elevator_exists { get; set; }
        public int floor { get; set; }
        public int years_experience { get; set; }
        public int Max_num_child { get; set; }
        public int Min_age_child { get; set; }
        public int Max_age_child { get; set; }
        public bool allow_rate_per_hour { get; set; }
        public double hourly_rate { get; set; }
        public double monthly_rate { get; set; }
        private Work_Schedule[] work_schedule = new Work_Schedule[(int)days.size];

    }
}
