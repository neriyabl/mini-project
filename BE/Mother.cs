using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    class Mother
    {
        //------------proportis and fields----------
        public readonly String ID;
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string phone_number { get; set; }
        public string address { get; set; }
        public string area_search { get; set;}
        private Work_Schedule[] work_schedule = new Work_Schedule[6];
        public Work_Schedule[] Work_schedule
        {
            get
            {
                return work_schedule;
            }
        }
        public string comment { get; set; }







        //---------------Methods---------------
        public override string ToString()
        {
            return
                (
                "The Mother: " + first_name + " " + last_name + "\n"
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
