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

        private readonly number iD;
        public number ID
        {
            get
            {
                return iD;
            }
        }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public DateTime date_of_birth { get; set; }
        public number phone_number { get; set; }
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
        private Work_Schedule[] work_schedule = new Work_Schedule[6];
        public Work_Schedule[] Work_schedule
        {
            get
            {
                return work_schedule;
            }
        }
        public bool Education_or_ITL { get; set; }
        public string feedbacks { get; set; }
        public int age
        {
            get
            {
                int age_year;
                age_year = (int.Parse(DateTime.Today.ToString("yyyyMMdd")) - int.Parse(date_of_birth.ToString("yyyyMMdd"))) / 10000;
                return age_year;
            }
        }

        //---------------Methods---------------
        public override string ToString()
        {
            return
                (
                "The Nanny: " + first_name + " " + last_name + "\n"
                + "ID: " + ID + "\t"
                + "Phone number: " + phone_number + "\n"
                + "Address: " + address.Replace(",", ", ") + "\n"
                );
        }

        //---------add and remove data in work schedule-------
        public void set_day_in_schedule(int day, DateTime start, DateTime end) { work_schedule[day] = new Work_Schedule(start, end); }
        public void remove_day_from_schedule(int day) { work_schedule[day].works = false; }
        //---------------------------------------------------------------------------------
    }
}
