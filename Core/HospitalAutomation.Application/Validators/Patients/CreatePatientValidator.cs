using FluentValidation;
using HospitalAutomation.Application.ViewModels.Patients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalAutomation.Application.Validators.Patients
{
    public class CreatePatientValidator : AbstractValidator<VM_Create_Patient>
    {
        public CreatePatientValidator()
        {
            RuleFor(p => p.Name)
                .NotEmpty().NotNull().WithMessage("Lütfen adınızı giriniz")
                .MinimumLength(3).MaximumLength(25).WithMessage("Minimum 3, maksimum 25 harf ");
            RuleFor(p => p.Surname).NotEmpty().NotNull().WithMessage("Lütfen soyadınızı giriniz")
                .MinimumLength(3).MaximumLength(25).WithMessage("Minimum 3, maksimum 25 harf ");
            RuleFor(p => p.FatherName).NotEmpty().NotNull().WithMessage("Lütfen babanızın adını giriniz")
                .MinimumLength(3).MaximumLength(25).WithMessage("Minimum 3, maksimum 25 harf ");
            RuleFor(p=> p.MotherName).NotEmpty().NotNull().WithMessage("Lütfen annenizin adını giriniz")
                .MinimumLength(3).MaximumLength(25).WithMessage("Minimum 3, maksimum 25 harf ");
            RuleFor(p => p.IdentificationNumber).NotEmpty().NotNull().WithMessage("Lütfen TC kimlik numaranızı giriniz")
                .Length(11).Matches("^[0-9]*$").WithMessage("TC kimlik numaranızı 11 hane olacak şekilde giriniz");
        }
    }
}
