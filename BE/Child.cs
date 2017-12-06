using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    class Child
    {
        //------------proportis and fields----------
        private readonly string iD;
        public string ID
        {
            get
            {
                return iD;
            }
        }
        private readonly string iD_of_mother;
        public string ID_of_mother
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
