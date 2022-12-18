using McSystems.DataAccess;
using McSystems.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McSystems.Business
{
    //DDD
    //Domain Driven Design
    public class EmployeeService
    {
        private McSystemsContext _context = new McSystemsContext();
        //CRUD servislerinde standart 5 adet metot yer alır
        //GetById
        //GetAll
        //Create
        //Update
        //Delete

        public EmployeeDto? GetById(int id)
        {
            var context = new McSystemsContext();
            try
            {
                return context.Employees.Select(emp => new EmployeeDto()
                {
                    Id = emp.Id,
                    FirstName = emp.FirstName,
                    LastName = emp.LastName,
                    Gender = emp.Gender,
                    DateOfBirth = emp.DateOfBirth,
                    HireDate = emp.HireDate,
                }).FirstOrDefault(emp => emp.Id == id);
            }
            catch (Exception)
            {

                return null;
            }
            //try
            //{
            //    var employee = context.Employees.Find(id);
            //    if (employee != null)
            //    {
            //        return new EmployeeDto()
            //        {
            //            Id = employee.Id,
            //            FirstName = employee.FirstName,
            //            LastName = employee.LastName,
            //            DateOfBirth = employee.DateOfBirth,
            //            HireDate = employee.HireDate,
            //        };
            //    }
            //    else
            //    {
            //        return default;
            //    }
            //}
            //catch (Exception ex)
            //{
            //    return default;
            //}
        }
        public List<EmployeeDto> GetAll()
        {
            var context = new McSystemsContext();
            try
            {
                return context.Employees.Select(MapToDto).ToList();
            }
            catch (Exception)
            {
                return new List<EmployeeDto>();
            }
        }
        public CommandResult Create(EmployeeDto employeeDto)
        {
            var employee = MapToEntity(employeeDto);
            try
            {
                _context.Employees.Add(employee);
                _context.SaveChanges();
                return CommandResult.Success();
            }
            catch (Exception ex)
            {
                return CommandResult.Failure(ex);
            }
        }
        public CommandResult Update(EmployeeDto employeeDto)
        {
            var employee = MapToEntity(employeeDto);
            _context.Employees.Update(employee);
            try
            {
                _context.SaveChanges();
                return CommandResult.Success("Güncelleme Başarılı");
            }
            catch (Exception ex)
            {
                return CommandResult.Failure("Güncelleme Hatası", ex);
                throw;
            }
        }
        //Arayüzden id alıp silme işlemi yapılıcak
        //public CommandResult Delete(EmployeeDto employee)
        //{
        //    return Delete(employee.Id);
        //}
        public CommandResult Delete(int id)
        {
            var employee = new Employee() { Id = id };
            try
            {
                _context.Employees.Remove(employee);
                return CommandResult.Success("Silme işlemi başarılı");
            }
            catch (Exception ex)
            {
                return CommandResult.Failure("Silme işlemi başarısız", ex);
            }
        }

        //Entity nesneyi DTO nesneye mapleyen metot
        private EmployeeDto MapToDto(Employee employee)
        {
            return new EmployeeDto()
            {
                Id = employee.Id,
                FirstName = employee.FirstName,
                LastName = employee.LastName,
                Gender = employee.Gender,
                DateOfBirth = employee.DateOfBirth,
                HireDate = employee.HireDate,
            };
        }
        private Employee MapToEntity(EmployeeDto employeeDto)
        {
            return new Employee()
            {
                Id = employeeDto.Id,
                FirstName = employeeDto.FirstName,
                LastName = employeeDto.LastName,
                Gender = employeeDto.Gender,
                DateOfBirth = employeeDto.DateOfBirth,
                HireDate = employeeDto.HireDate,
            };
        }
    }
}
