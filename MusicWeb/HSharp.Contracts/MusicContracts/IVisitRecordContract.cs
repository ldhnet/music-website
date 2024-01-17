
using HSharp.Entity.SystemManage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSharp.Contracts.MusicContracts
{
    public interface IVisitRecordContract
    {
        List<VisitRecord> GetVisitRecordList();
        Task<VisitRecord> FindAsync();
        bool SaveEntity(VisitRecord employee);
    }
}
