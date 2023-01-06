using PersonalTracking.WPF.DataBase;
using PersonalTracking.WPF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
        public List<DepartmentDTO> GetAllDepartments()
        {
            var departments = _context.Departments.OrderBy(d => d.Id).ToList(); 
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
                return departmentDtos;
            }
            catch
            {
                return null; 
            }
        }
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

    }
}
