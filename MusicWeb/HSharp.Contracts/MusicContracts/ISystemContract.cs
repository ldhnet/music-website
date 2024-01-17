using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSharp.Contracts.MusicContracts
{
    public interface ISystemContract
    {
        public DateTime GetCurrentMonth();
        public int GetCurrentID();
    }
}
