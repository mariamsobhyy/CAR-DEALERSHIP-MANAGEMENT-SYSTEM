using AutoMapper;
using CAR_DEALERSHIP_MANAGEMENT_SYSTEM.DTOs.CategoryDto;
using CAR_DEALERSHIP_MANAGEMENT_SYSTEM.DTOs.CustomerDTO;
using CAR_DEALERSHIP_MANAGEMENT_SYSTEM.DTOs.CustomerProfileDTO;
using CAR_DEALERSHIP_MANAGEMENT_SYSTEM.DTOs.EmloyeeeDTO;
using CAR_DEALERSHIP_MANAGEMENT_SYSTEM.DTOs.SaleDTO;
using CAR_DEALERSHIP_MANAGEMENT_SYSTEM.DTOs.VehicleDTO;
using CAR_DEALERSHIP_MANAGEMENT_SYSTEM.Models;
using System.Numerics;

namespace CAR_DEALERSHIP_MANAGEMENT_SYSTEM.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Category, CaregotyDto>();
            CreateMap<CreateCaregotyDto, Category>();
            CreateMap<UpdateCaregotyDto, Category>();



            CreateMap<Customer, CutomerDto>();
            CreateMap<CreateCusomerDto, Customer>();
            CreateMap<UpdateCustomerDto, Customer>();


            CreateMap<CustomerProfile, CustomerProfileDto>();
            CreateMap<CreateCustomerProfileDto, CustomerProfile>();
            CreateMap<UpdateCustomerProfileDto, CustomerProfile>();


            CreateMap<Employee, EmployeeDto>();
            CreateMap<CreateEmployee, Employee>();
            CreateMap<UpdateEmployee, Employee>();

            CreateMap<Vehicle, VehicleDto>();
            CreateMap<CreateVehicleDto, Vehicle>();
            CreateMap<UpdateVehicleDto, Vehicle>();

            CreateMap<Sale, SaleDto>();
            CreateMap<CreateSaleDto, Sale>();
            CreateMap<UpdateSaleDto, Sale>();



        }
    }
}
