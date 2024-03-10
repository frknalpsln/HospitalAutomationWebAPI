using HospitalAutomation.Application.Repositories;
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
    public class ProtocolWriteRepository : WriteRepository<Protocol>, IProtocolWriteRepository
    {
        public ProtocolWriteRepository(HospitalAutomationDbContext context) : base(context)
        {
        }
    }
}
