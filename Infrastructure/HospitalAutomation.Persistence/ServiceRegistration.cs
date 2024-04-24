using HospitalAutomation.Application.Repositories.AppointmentRepo;
using HospitalAutomation.Application.Repositories.DoctorRepo;
using HospitalAutomation.Application.Repositories.PatientRepo;
using HospitalAutomation.Persistence.Contexts;
using HospitalAutomation.Persistence.Repositories.AppointmentRepo;
using HospitalAutomation.Persistence.Repositories.DoctorRepo;
using HospitalAutomation.Persistence.Repositories.PatientRepo;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace HospitalAutomation.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services)
        {
            services.AddDbContext<HospitalAutomationDbContext>(options => options.UseNpgsql(Configuration.ConnectionString));
            services.AddScoped<IPatientReadRepository, PatientReadRepository>();
            services.AddScoped<IPatientWriteRepository, PatientWriteRepository>();
            services.AddScoped<IDoctorReadRepository, DoctorReadRepository>();
            services.AddScoped<IDoctorWriteRepository, DoctorWriteRepository>();
            services.AddScoped<IProtocolReadRepository, ProtocolReadRepository>();
            services.AddScoped<IProtocolWriteRepository, ProtocolWriteRepository>();
         
        }
    }
}
