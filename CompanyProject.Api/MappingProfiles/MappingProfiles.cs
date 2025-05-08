using AutoMapper;
using CompanyProject.Api.Dtos.DepartnebtDtos;

using CompanyProject.DAL.Data;

namespace CompanyProject.Api.MappingProfiles
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Department , DepartmentDto>().ReverseMap();
            CreateMap<Department , CreateDepartmentDto>().ReverseMap();
            CreateMap<Department , UpdateDepartmentDto>().ReverseMap();
            CreateMap<SubDepartment , SubDepartmentDto>().ReverseMap();
            CreateMap<Employee , EmployeeDto>().ReverseMap();
         
        }
    }
}
