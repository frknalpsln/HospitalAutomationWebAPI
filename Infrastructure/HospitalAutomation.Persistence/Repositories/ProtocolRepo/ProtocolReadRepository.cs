using HospitalAutomation.Application.Repositories.AppointmentRepo;
using HospitalAutomation.Domain.Entities;
using HospitalAutomation.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalAutomation.Persistence.Repositories.AppointmentRepo
{
    public class ProtocolReadRepository : ReadRepository<Protocol>, IProtocolReadRepository
    {
        public ProtocolReadRepository(HospitalAutomationDbContext context) : base(context)
        {
        }
    }
}
