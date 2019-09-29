using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ticketAppV2
{
    interface IRoadPatroler
    {
        double fine();
        string validateID(string id);
    }
}
