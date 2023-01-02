using McSystems.Customers;
using McSystems.DataAccess;
using McSystems.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McSystems.Business
{
    public class CountryService
    {
        private McSystemsContext _context = new McSystemsContext();
        public List<CountryDto> GetAll()
        {
            try
            {
                return _context.Countries.Select(MapToDto).ToList();
            }
            catch (Exception)
            {
                return new List<CountryDto>();
            }
        }
        private CountryDto MapToDto(Country country)
        {
            return new CountryDto()
            {
                Id = country.Id,
                Name = country.Name,
            };
        }
    }
}
