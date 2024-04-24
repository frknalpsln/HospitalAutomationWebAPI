using FluentValidation.AspNetCore;
using HospitalAutomation.Application;
using HospitalAutomation.Application.Validators.Doctors;
using HospitalAutomation.Application.Validators.Patients;
using HospitalAutomation.Infrastructure.Filters;
using HospitalAutomation.Persistence;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddPersistenceServices();
builder.Services.AddApplicationServices();
builder.Services.AddCors(options => options.AddDefaultPolicy(policy => policy.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod()));
builder.Services.AddAuthorization();
builder.Services.AddControllers(options => options.Filters.Add<ValidationFilter>()).AddFluentValidation(configuration => {
    configuration.RegisterValidatorsFromAssemblyContaining<CreatePatientValidator>();
    configuration.RegisterValidatorsFromAssemblyContaining<CreateDoctorValidator>();
})
    .ConfigureApiBehaviorOptions(options => options.SuppressModelStateInvalidFilter = true);
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors();
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
