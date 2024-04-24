using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalAutomation.Application.Features.Queries.Patients.GetByIdPatients
{
    public class GetByIdPatientsQueryRequest : IRequest<GetByIdPatientsQueryResponse>
    {
        public string Id { get; set; }
    }
}
