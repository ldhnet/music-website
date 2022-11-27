using Framework.Repository.Data;
using Framework.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework.Admin.Contracts;
using System.Linq.Expressions;
using Framework.Repository;

namespace Framework.Admin.Service
{
    public class VisitRecordService : IVisitRecordContract
    {
        private IVisitRecordRepository _visitRecordRepository;

        public VisitRecordService(IVisitRecordRepository visitRecordRepository)
        {
            this._visitRecordRepository = visitRecordRepository;
        }

        
       public List<VisitRecord> GetVisitRecordList()
        {
            var list = _visitRecordRepository.EntitiesAsNoTracking.ToList();
            return list;
        }
        public async Task<VisitRecord> FindAsync()
        {
            return await _visitRecordRepository.GetByKeyAsync(1);
        }
         
        public bool SaveEntity(VisitRecord model)
        {
            int result = _visitRecordRepository.Insert(model);
            return result > 0;
        } 
    }
}
