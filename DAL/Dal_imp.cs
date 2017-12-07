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

        //-------------------child list function---------------------
        public void add_child(Child child)
        {
            foreach (var item in DS.DataSource.Child_list)
            {
                if (item.ID == child.ID)
                    throw new Exception("the child already exist\n");
            }
            DS.DataSource.Child_list.Add(child);
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
        public void update_child(Child child)
        {
            throw new NotImplementedException();
        }

        //----------------contract list function------------------
        public void add_contract(Contract contract)
        {
            foreach (var item in DS.DataSource.Contract_list)
            {
                if (item.contract_number == contract.contract_number)
                    throw new Exception("the contract already exist\n");
            }
            DS.DataSource.Contract_list.Add(contract);
        }
        public void remove_contract(Contract contract)
        {
            foreach (var item in DS.DataSource.Contract_list)
            {
                if (item.contract_number == contract.contract_number)
                {
                    DS.DataSource.Contract_list.Remove(item);
                    return;
                }
            }

            throw new Exception("the contract does not exsist ");
        }
        public void update_contract(Contract contract)
        {
            throw new NotImplementedException();
        }
        
        //-----------------mother list function--------------------
        public void add_Mother(Mother mother)
        {
            foreach (var item in DS.DataSource.Mother_list)
            {
                if (item.ID == mother.ID)
                    throw new Exception("the mother already exist\n");
            }
            DS.DataSource.Mother_list.Add(mother);
        }
        public void remove_Mother(Mother mother)
        {
            foreach (var item in DS.DataSource.Mother_list)
            {
                if (item.ID == mother.ID)
                {
                    DS.DataSource.Mother_list.Remove(item);
                    return;
                }
            }
            throw new Exception("the mother does not exsist\n");
        }
        public void update_Mother(Mother mother)
        {
            throw new NotImplementedException();
        }
        
        //------------------nanny list function--------------------
        public void add_nanny(Nanny nanny)
        {
            throw new NotImplementedException();
        }
        public void remove_nanny(Nanny nanny)
        {
            {
                foreach (var item in DS.DataSource.Nanny_list)
                {
                    if (item.ID == nanny.ID)
                    {
                        DS.DataSource.Nanny_list.Remove(item);
                        return;
                    }
                }
                throw new Exception("the nanny does not exsist\n");
            }

        }
        public void remove_nanny(number nanny_id)
        {
            throw new NotImplementedException();
        }
        public void update_nanny(Nanny nanny)
        {
            throw new NotImplementedException();
        }

        public List<Nanny> nannys_list()
        {
            throw new NotImplementedException();
        }

        public List<Child> children_list()
        {
            throw new NotImplementedException();
        }

        public List<Child> Mothers_children(Mother mother)
        {
            throw new NotImplementedException();
        }

        public List<Child> Mothers_children(number mother_id)
        {
            throw new NotImplementedException();
        }

        public List<Contract> contracts_list()
        {
            throw new NotImplementedException();
        }

        public List<Mother> mothers_list()
        {
            throw new NotImplementedException();
        }
    }
}
