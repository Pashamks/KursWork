using System.Collections.Generic;
using System.Linq;

namespace KursWork.DataBase
{
    public class DbRepository
    {
        private EfCoreDbContext GetContext()
        {
            return new EfCoreDbContext();
        }
        public List<PlanTable> GetPlanList()
        {
            using(var ctx = GetContext())
            {
                return ctx.PlanTable.ToList();
            }
        }
    }
}
