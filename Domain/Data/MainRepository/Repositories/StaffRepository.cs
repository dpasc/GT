using Library.Models.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Data.MainRepository.Repositories
{
    public class StaffRepository:MainRepository<Employee,GTContext>
    {

        public StaffRepository(GTContext context) :base(context)
        {

        }

        public async Task<Employee> GetEmployeeByUserId(string userId)
        {
            var person = await context.Set<Person>()
                .FirstOrDefaultAsync(person => person.UserId == userId);
            Employee emp = person as Employee;
            return emp;
        }

        public  async Task<List<TravelPackage>> GetAllTravelPackages()
        {
            return await context.Set<TravelPackage>().ToListAsync();
        }


    }
}
