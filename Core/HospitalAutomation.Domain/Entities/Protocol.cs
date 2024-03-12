using HospitalAutomation.Domain.Entities.Common;
using HospitalAutomation.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalAutomation.Domain.Entities
{
    public class Protocol : BaseEntity
    {

        public string Definition { get; set; }
        public string Department { get; set; }

        public Guid DoctorId { get; set; }
        public Guid PatientId { get; set; }
        public Guid PoliclinicId { get; set; }
        public Doctor Doctor { get; set; }
        public Patient Patient { get; set; }
        public Policlinic Policlinic { get; set; }
        public InsuranceType InsuranceType { get; set; }
        public TreatmentType TreatmentType { get; set; }
        public ProvisionType ProvisionType { get; set; }
        public TrackingType TrackingType { get; set; }      
        public PoliclinicType PoliclinicType { get; set; }

    }
}
