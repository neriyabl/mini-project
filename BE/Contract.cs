using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Contract
    {
        //------------proportis and fields----------
        private static int numbers_of_contracts = 10000000;
        public readonly number contract_number = new number(numbers_of_contracts.ToString());
        private readonly number iD_of_nany;
        public number ID_of_nany
        {
            get
            {
                return iD_of_nany;
            }
        }
        private readonly number iD_of_child;
        public number ID_of_child
        {
            get
            {
                return iD_of_child;
            }
        }
        public bool was_meet { get; set; }
        public bool was_signed { get; set; }
        public double salary_per_hour { get; set; }
        public double salary_per_month { get; set; }
        public bool is_global_salary { get; set; }
        public DateTime date_start_of_work { get; set; }
        public DateTime date_end_of_work { get; set; }


        //---------------Methods---------------
        public override string ToString()
        {
            string salary = is_global_salary ? ("Salary Per Month: " + salary_per_month.ToString()) :
                ("Salary Per Hour: " + salary_per_hour.ToString());
            return
                (
                "Contract Number: " + contract_number + "\n"
                + "The Nanny ID: " + iD_of_nany + "\t"
                + "The Child ID: " + iD_of_child + "\n"
                + salary + "\n"
                + "Date Of Start Work: " + date_start_of_work + "\t"
                + "Date Of End Work: " + date_end_of_work + "\n"
                );
        }


        //----------------constructors--------------
        public Contract()
        {
            numbers_of_contracts++;
        }
    }
}
