using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Child
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
        private readonly number iD_of_mother;
        public number ID_of_mother
        {
            get
            {
                return iD_of_mother;
            }
        }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public DateTime date_of_birth { get; set; }
        public bool is_special_needs { get; set; }
        public string special_needs { get; set; }
        public string address { get; set; }
        public int age
        {
            get
            {
                int age_year;
                int age_month;
                age_year = (int.Parse(DateTime.Today.ToString("yyyyMMdd")) - int.Parse(date_of_birth.ToString("yyyyMMdd"))) / 10000;
                age_month = (int.Parse(DateTime.Today.ToString("MMdd")) - int.Parse(date_of_birth.ToString("MMdd"))) / 100;
                return (age_year * 12 + age_month);
            }
        }

        //---------------Methods---------------
        public override string ToString()
        {
            string special_needs_str = is_special_needs ? ("Special Needs: " + special_needs) : "";
            return
                (
                "The Child: " + first_name + " " + last_name + "\n"
                + "ID: " + ID + "\t"
                + "Address: " + address.Replace(",", ", ") + "\n"
                + special_needs_str
                );
        }

    }
}
