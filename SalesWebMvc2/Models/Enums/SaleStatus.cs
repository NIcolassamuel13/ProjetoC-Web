using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc2.Models.Enums
{
    public enum SaleStatus: int
    {

        pending= 0,
            Billed= 1,
            canceled= 2
    }
}
