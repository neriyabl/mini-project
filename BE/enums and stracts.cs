using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    enum days { Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, size }

    struct Work_Schedule
    {
        bool works;
        DateTime start_hour;
        DateTime end_hour;
    }
}
