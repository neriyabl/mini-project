using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface Idal
    {
        //---------------Methods nanny---------------
        void add_nanny(BE.Nanny nanny);
        void remove_nanny(BE.Nanny nanny);
        void remove_nanny(BE.number nanny_id);
        void update_nanny(BE.Nanny nanny);
        List<BE.Nanny> nannys_list();

        //---------------Methods child---------------
        void add_child(BE.Child child);
        void remove_child(BE.Child child);
        void remove_child(BE.number child_id);
        void update_child(BE.Child child);
        List<BE.Child> children_list();
        List<BE.Child> Mothers_children(BE.Mother mother);
        List<BE.Child> Mothers_children(BE.number mother_id);

        //---------------Methods contract---------------
        void add_contract(BE.Contract contract);
        void remove_contract(BE.Contract contract);
        void update_contract(BE.Contract contract);
        List<BE.Contract> contracts_list();

        //---------------Methods mother---------------
        void add_Mother(BE.Mother mother);
        void remove_Mother(BE.Mother mother);
        void update_Mother(BE.Mother mother);
        List<BE.Mother> mothers_list();
        
    }
}
