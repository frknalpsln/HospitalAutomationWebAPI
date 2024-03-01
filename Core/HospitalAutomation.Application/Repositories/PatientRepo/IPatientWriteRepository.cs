﻿using HospitalAutomation.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalAutomation.Application.Repositories.PatientRepo
{
    public interface IPatientWriteRepository : IWriteRepository<Patient>
    {
    }
}
