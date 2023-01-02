using McSystems.Customers;
using McSystems.DataAccess;
using McSystems.DataAccess.Entities;

namespace McSystems.Business
{
    public class CustomerService
    {
        private McSystemsContext _context = new McSystemsContext();

        public List<CustomerRegistrationInfo> SearchCustomers(string identityNumber,
            string firstName,
            string lastName)
        {
            var query = from customer in _context.Customers select customer;
            if (!string.IsNullOrWhiteSpace(identityNumber))
            {
                query = from customer in query where customer.IdNumber == identityNumber select customer;
            }
            if (!string.IsNullOrWhiteSpace(firstName))
            {
                query = query.Where(customer => customer.FirstName.Contains(firstName));
            }
            if (!string.IsNullOrWhiteSpace(lastName))
            {
                query = query.Where(customer => customer.LastName.Contains(lastName));
            }
            return query.Select(MapToRegistration).ToList();
        }
        public CustomerDto? GetById(int id)
        {
            try
            {
                var customerDto = _context.Customers.Select(MapToDto).FirstOrDefault(customer => customer.Id == id);
                return customerDto;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public List<CustomerDto> GetAll()
        {
            try
            {
                return _context.Customers.Select(MapToDto).ToList();
            }
            catch (Exception)
            {
                return new List<CustomerDto>();
            }
        }
        public CommandResult Create(CustomerDto customerDto)
        {
            var customer = MapToEntity(customerDto);
            customer.CreatedDate = DateTime.Now;
            try
            {
                _context.Customers.Add(customer);
                _context.SaveChanges();
                return CommandResult.Success();
            }
            catch (Exception ex)
            {
                return CommandResult.Failure(ex);
            }
        }
        public CommandResult Delete(CustomerDto customerDto)
        {
            //TODO: Aynı id instance alınmış daha önce diyor
            try
            {
                var customer = new Customer() 
                { 
                    Id = customerDto.Id,
                    IdNumber = customerDto.IdNumber,
                    FirstName = customerDto.FirstName,
                    LastName = customerDto.LastName,
                    Phone = customerDto.Phone,
                    EmailAddress = customerDto.EmailAddress,
                    CountryId = customerDto.CountryId,
                    Gender = customerDto.Gender,
                    CreatedDate = DateTime.Now,
                };
                _context.Customers.Remove(customer);
                _context.SaveChanges();
                return CommandResult.Success("Silme işlemi başarılı");
            }
            catch (Exception ex)
            {
                return CommandResult.Failure("Silme işlemi hatalı", ex);
            }
        }
        public CommandResult Update(CustomerDto customerDto)
        {
            var customer = MapToEntity(customerDto);
            //TODO: id izlendiği için hata veriyor ikinci izleme yapılamıyor
            _context.Customers.Update(customer);
            try
            {
                _context.SaveChanges();
                return CommandResult.Success("Güncelleme başarılı");
            }
            catch (Exception ex)
            {
                return CommandResult.Failure("Güncelleme hatası", ex);
            }
        }
        private CustomerRegistrationInfo MapToRegistration(Customer customer)
        {
            return new CustomerRegistrationInfo()
            {
                Id = customer.Id,
                IdNumber = customer.IdNumber,
                FullName = string.Concat(customer.FirstName, ' ', customer.LastName),
                CreatedDate = customer.CreatedDate
            };
        }

        //TODO: reservation Datasource countryleri de getir
        //private CustomerSummary MapToSummary(CustomerDto customerDto)
        //{
        //    return new CustomerSummary()
        //    {
        //        CountryName = customerDto.CountryId
        //    };
        //}
        private Customer MapToEntity(CustomerDto customerDto)
        {
            //string[] fullName = customerDto.FullName.Split(' ');
            //var firstName = string.Empty;
            //var lastName = string.Empty;
            //for (int i = 0; i < fullName.Length; i++)
            //{
            //    if (i != fullName.Length - 1)
            //    {
            //        if (firstName == string.Empty)
            //        {
            //            firstName = string.Concat(fullName[i], ' ');
            //        }
            //        else
            //        {
            //            firstName = firstName + ' ' + fullName[i];
            //        }
            //    }
            //    else
            //    {
            //        lastName = fullName[fullName.Length - 1];
            //    }
            //}
            return new Customer()
            {
                Id = customerDto.Id,
                IdNumber = customerDto.IdNumber,
                FirstName = customerDto.FirstName,
                LastName = customerDto.LastName,
                Phone = customerDto.Phone,
                EmailAddress = customerDto.EmailAddress,
                Gender = customerDto.Gender,
                CountryId = customerDto.CountryId,
            };
        }
        private CustomerDto MapToDto(Customer customer)
        {
            return new CustomerDto()
            {
                Id = customer.Id,
                IdNumber = customer.IdNumber,
                FirstName = customer.FirstName,
                LastName = customer.LastName,
                Phone = customer.Phone,
                EmailAddress = customer.EmailAddress,
                Gender = customer.Gender,
                CountryId = customer.CountryId,
            };
        }
    }
}
