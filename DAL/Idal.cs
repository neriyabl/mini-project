using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface Idal
    {
        //---------------Methods---------------
        void add_nanny(BE.Nanny nanny);
        void remove_nanny(BE.Nanny nanny);
        void update_nanny(BE.Nanny nanny);

        void add_child(BE.Child child);
        void remove_child(BE.Child child);
        void update_child(BE.Child child);

        void add_contract(BE.Contract contract);
        void remove_contract(BE.Contract contract);
        void update_contract(BE.Contract contract);

    }
}
