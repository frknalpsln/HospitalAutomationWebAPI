using HospitalAutomation.Application.Repositories.PoliclinicRepo;
using HospitalAutomation.Domain.Entities;
using HospitalAutomation.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalAutomation.Persistence.Repositories.PoliclinicRepo
{
    public class PoliclinicWriteRepository : WriteRepository<Policlinic>, IPoliclinicWriteRepository
    {
        public PoliclinicWriteRepository(HospitalAutomationDbContext context) : base(context)
        {
        }
    }
}
