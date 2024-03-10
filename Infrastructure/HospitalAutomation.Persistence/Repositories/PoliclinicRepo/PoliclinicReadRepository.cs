using HospitalAutomation.Application.Repositories.PoliclinicRepo;
using HospitalAutomation.Domain.Entities;
using HospitalAutomation.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalAutomation.Persistence.Repositories.PoliclinicRepor
{
    public class PoliclinicReadRepository : ReadRepository<Policlinic>, IPoliclinicReadRepository
    {
        public PoliclinicReadRepository(HospitalAutomationDbContext context) : base(context)
        {
        }
    }
}
