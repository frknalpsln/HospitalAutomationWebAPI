using HospitalAutomation.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalAutomation.Domain.Enums
{
    public enum TrackingType
    {
        Normal = 1,
        Comorbidity,
        Bed,
        LongTermStay,
        DiagnosticPurposes,
        Daily,
        Death

    }
}
