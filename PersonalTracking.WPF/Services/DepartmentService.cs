using Microsoft.EntityFrameworkCore;
using PersonalTracking.WPF.DataBase;
using PersonalTracking.WPF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalTracking.WPF.Services
{
   public class DepartmentService
    {
        private PersonalTrackingDbContext _context;

        public DepartmentService()
        {
            _context= new PersonalTrackingDbContext();  
        }

        // Get All Departments //
        public async Task<List<DepartmentDTO>> GetAllDepartments()
        {
            var departments = await _context.Departments.OrderBy(d => d.Id).ToListAsync(); 
            var departmentDtos = new List<DepartmentDTO>();
            try
            {
                if (departments.Any())
                {
                    foreach (Department department in departments)
                    {
                        var depDTO = new DepartmentDTO()
                        {
                            DepartmentId = department.Id,
                            DepartmentName = department.DepartmentName
                        };
                        departmentDtos.Add(depDTO);
                    }
                }
                return  departmentDtos;
            }
            catch
            {
                return null; 
            }
        }
        // Add a New Department //
        public bool AddDepartment(DepartmentDTO department)
        {
            var success = false;
            if (department != null)
            {
                var departmentToAdd = new Department()
                {
                    Id = department.DepartmentId,
                    DepartmentName = department.DepartmentName,
                };
                _context.Departments.Add(departmentToAdd); 
                _context.SaveChanges();
                success = true;
            }
            return success;
        }

        // Update A New Department //
        public async Task<DepartmentDTO> UpdateDepartment(DepartmentDTO department)
        {
            try
            {
                var departmentToUpdate = await _context.Departments.FirstOrDefaultAsync(d => d.Id == department.DepartmentId);
                if (departmentToUpdate != null)
                {
                    departmentToUpdate.DepartmentName = department.DepartmentName;
                    departmentToUpdate.Id = department.DepartmentId;
                    _context.SaveChanges();
                    department.DepartmentName = departmentToUpdate.DepartmentName;
                    department.DepartmentId = departmentToUpdate.Id;
                }
                return department;
            }
            catch
            {
                return null;
            }
  
        }

    }
}
