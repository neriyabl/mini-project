using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace DAL
{
    class Dal_imp : Idal
    {
        public void add_child(Child child)
        {
            foreach (var item in DS.DataSource.Child_list)
            {
                if (item.ID == child.ID)
                    throw new Exception("the child already exist\n");
            }
            DS.DataSource.Child_list.Add(child);
        }

        public void add_contract(Contract contract)
        {
            throw new NotImplementedException();
        }

        public void add_Mother(Mother mother)
        {
            throw new NotImplementedException();
        }

        public void add_nanny(Nanny nanny)
        {
            throw new NotImplementedException();
        }






        public void remove_child(Child child)
        {
            foreach (var item in DS.DataSource.Child_list )
            {
                if(item.ID==child.ID)
                {
                    DS.DataSource.Child_list.Remove(item);
                    return;
                }
            }
            throw new Exception("this child not exist\n");
        }

        public void remove_contract(Contract contract)
        {
            throw new NotImplementedException();
        }

        public void remove_Mother(Mother mother)
        {
            throw new NotImplementedException();
        }

        public void remove_nanny(Nanny nanny)
        {
            throw new NotImplementedException();
        }










        public void update_child(Child child)
        {
            throw new NotImplementedException();
        }

        public void update_contract(Contract contract)
        {
            throw new NotImplementedException();
        }

        public void update_Mother(Mother mother)
        {
            throw new NotImplementedException();
        }

        public void update_nanny(Nanny nanny)
        {
            throw new NotImplementedException();
        }
    }
}
