using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Admin.Contracts
{
    public interface ISystemContract 
    {
        public DateTime GetCurrentMonth();
        public int GetCurrentID();
    }
}
