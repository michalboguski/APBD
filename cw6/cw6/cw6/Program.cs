using cw6;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<s25236Database>(opt =>
    opt.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddScoped<IPatientRepository, PatientRepositoryImpl>();
builder.Services.AddScoped<IMedicamentRepository, MedicamentRepositoryImpl>();
builder.Services.AddScoped<IPrescriptionMedicamentRepository, PrescriptionMedicamentImpl>();
builder.Services.AddScoped<IPrescriptionRepository, PrescriptionRepositoryImpl>();
builder.Services.AddScoped<IPrescriptionService, PrescriptionServiceImpl>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();


app.Run();

