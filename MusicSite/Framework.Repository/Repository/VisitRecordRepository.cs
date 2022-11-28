using Framework.Models.Entities;
using Framework.Repository.Data; 

namespace Framework.Repository
{
    public class VisitRecordRepository : Repository<VisitRecord, int>, IVisitRecordRepository
    {
        public VisitRecordRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {

        }
        public IQueryable<VisitRecord> GetVisitRecordList()
        {
            return EntitiesAsNoTracking.Where(c=>c.Id > 0); 
        }
    }
}
