using CAR_DEALERSHIP_MANAGEMENT_SYSTEM.Data;
using CAR_DEALERSHIP_MANAGEMENT_SYSTEM.Mapping;
using CAR_DEALERSHIP_MANAGEMENT_SYSTEM.Models;
using CAR_DEALERSHIP_MANAGEMENT_SYSTEM.Repos.Implemntation;
using CAR_DEALERSHIP_MANAGEMENT_SYSTEM.Repos.Interface;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));


builder.Services.AddAutoMapper(config => config.AddProfile<MappingProfile>());

builder.Services.AddScoped<IGenaricRepo<Employee>, GenaricRepo<Employee>>();
builder.Services.AddScoped<IGenaricRepo<CustomerProfile>, GenaricRepo<CustomerProfile>>();
builder.Services.AddScoped<IGenaricRepo<Vehicle>, GenaricRepo<Vehicle>>();
builder.Services.AddScoped<IGenaricRepo<Category>, GenaricRepo<Category>>();
builder.Services.AddScoped<IGenaricRepo<Sale>, GenaricRepo<Sale>>();
builder.Services.AddScoped<IGenaricRepo<Customer>, GenaricRepo<Customer>>();

builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
