using AutoMapper;
using CompanyProject.Api.Dtos.DepartnebtDtos;
using CompanyProject.DAL.Data;
using CompanyProject.PLL.implementation;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net.WebSockets;

namespace CompanyProject.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DeparmentController : ControllerBase {
        private readonly IDepartmentRepository _departmentRepository;
        private readonly IMapper mapper;

        public DeparmentController(IDepartmentRepository departmentRepository ,IMapper mapper)
         {
        
            _departmentRepository = departmentRepository;
            this.mapper = mapper;
        }


    [HttpGet("GetAll")]
    public async Task<ActionResult<IEnumerable<DepartmentDto>>> GetAllDepartments()
    {
        
            var departments = await _departmentRepository.GetAllDepartmentWithDetilsAsync();
                var departmentsdto = mapper.Map<List<DepartmentDto>>(departments); 
            return Ok(departmentsdto);
       
       
    }

    
    [HttpGet("GetBy{id}")]
    public async Task<ActionResult<DepartmentDto>> GetDepartmentById(int id)
    {
      
            var department = await _departmentRepository.GetDepartmentWithDetilByIdAsync(id);
                   

            if (department == null)
            {
                return NotFound($"Department with ID {id} not found");
            }
                var departmentDto = mapper.Map<DepartmentDto>(department); 
            
            return Ok(departmentDto);
       
        
    }

    [HttpPost("Create")]
    public async Task<ActionResult<Department>> CreateDepartment([FromBody] CreateDepartmentDto departmentdto)
    {

            try
            {
                var Depatmet = mapper.Map<Department>(departmentdto);
                await _departmentRepository.AddAsync(Depatmet);
                return Ok("Department Create");
            }catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }

        
    }

   
    [HttpPut("Update{id}")]
    public async Task<IActionResult> UpdateDepartment(int id ,  UpdateDepartmentDto updateDepartmentDto)
    {
        try
        {
           if(id !=updateDepartmentDto.Id)
           {
                    return BadRequest(); 
           }
               

            var department = await _departmentRepository.GetByIdAsync(updateDepartmentDto.Id);
            if (department == null)
            {
                return NotFound($"Department with ID {updateDepartmentDto.Id} not found");
            }
       mapper.Map(updateDepartmentDto, department); 
           await _departmentRepository.UpdateAsync(department);

                return Ok("Department updateed");
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

   
    [HttpDelete("Delete{id}")]
    public async Task<IActionResult> DeleteDepartment(int id)
    {
        try
        {
            var department = await _departmentRepository.GetByIdAsync(id);
            if (department == null)
            {
                return NotFound($"Department with ID {id} not found");
            }

             await   _departmentRepository.DeleteAsync(department);

                return Ok("Department Deleted "); 
        }
        catch (Exception ex)
        {
                return BadRequest(ex.Message); 
        }
    }
}
}
