using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalAutomation.Application.Features.Queries.Patients.GetAllPatients
{
    public class GetAllPatientsQueryResponse
    {
        public int TotalCount { get; set; }
        public object Patients { get; set; }
    }
}
