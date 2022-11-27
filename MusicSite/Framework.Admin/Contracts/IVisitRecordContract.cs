using Framework.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Admin.Contracts
{
    public interface IVisitRecordContract
    {
        List<VisitRecord> GetVisitRecordList();
        Task<VisitRecord> FindAsync();  
        bool SaveEntity(VisitRecord employee); 
    }
}
