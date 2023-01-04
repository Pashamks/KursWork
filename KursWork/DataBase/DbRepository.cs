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

        public void AddPlan(PlanTable plan)
        {
            using(var ctx = GetContext())
            {
                ctx.PlanTable.Add(plan);
                ctx.SaveChanges();
            }
        }
        public void AddApplication(Applications app)
        {
            using(var ctx = GetContext())
            {
                ctx.Applications.Add(app);
                ctx.SaveChanges();
            }
        }
        public void AddOrganization(Organizations org)
        {
            using(var ctx = GetContext())
            {
                ctx.Organizations.Add(org);
                ctx.SaveChanges();
            }
        }
        public void AddSpecialization(Specializations spec)
        {
            using(var ctx = GetContext())
            {
                ctx.Specializations.Add(spec);
                ctx.SaveChanges();
            }
        }

        public void Remove(PlanTable plan)
        {
            using(var ctx = GetContext())
            {
                ctx.PlanTable.Remove(plan);
                ctx.SaveChanges();
            }
        }
        public void Remove(Applications app)
        {
            using(var ctx = GetContext())
            {
                ctx.Applications.Remove(app);
                ctx.SaveChanges();
            }
        }
        public void Remove(Organizations org)
        {
            using(var ctx = GetContext())
            {
                ctx.Organizations.Remove(org);
                ctx.SaveChanges();
            }
        }
        public void Remove(Specializations spec)
        {
            using(var ctx = GetContext())
            {
                ctx.Specializations.Remove(spec);
                ctx.SaveChanges();
            }
        }



    }
}
