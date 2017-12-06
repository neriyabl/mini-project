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
    }
}
