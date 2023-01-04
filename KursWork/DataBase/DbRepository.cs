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
        public List<Applications> GetApplicationsList()
        {
            using(var ctx = GetContext())
            {
                return ctx.Applications.ToList();
            }
        }
        public List<Organizations> GetOrganizationsList()
        {
            using(var ctx = GetContext())
            {
                return ctx.Organizations.ToList();
            }
        }
        public List<Specializations> GetSpecializationsList()
        {
            using(var ctx = GetContext())
            {
                return ctx.Specializations.ToList();
            }
        }

    }
}
