using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyApp.Models;

using System.Data.Entity;namespace MyApp.DB.DBOperations
{
    public class empRepository
    {
        public int AddEmployee(EmployeeModel model)
        {
            using (var Context = new EmpDBEntities())
            {
                var emp = new employee
                {
                    Name = model.Name,
                    EmailId = model.EmailId,
                    PhoneNumber = model.PhoneNumber,
                    address = new address
                    {
                        city = model.address.city,
                        state = model.address.state,
                    }
                };
                Context.Entry(emp).State = System.Data.Entity.EntityState.Added;
                //Context.employee.Add(emp);
                Context.SaveChanges();
                return emp.Id;
            }
        }

        public List<EmployeeModel> GetAllEmployee()
        {
            using (var Context = new EmpDBEntities())
            {
                var Result = Context.employee
                    .Select(X => new EmployeeModel()
                    {
                        Id = X.Id,
                        AddressId = X.AddressId,
                        Name = X.Name,
                        EmailId = X.EmailId,
                        PhoneNumber = X.PhoneNumber,
                        address = new AddressModel()
                        {
                            state = X.address.state,
                            city = X.address.city,
                            Id = X.address.Id,
                        }
                    }).ToList();
                return Result;
            }
        }


        public EmployeeModel GetEmployee(int Id)
        {
            using (var Context = new EmpDBEntities())
            {
                var Result = Context.employee.Where(x => x.Id == Id)
                    .Select(X => new EmployeeModel()
                    {
                        Id = X.Id,
                        AddressId = X.AddressId,
                        Name = X.Name,
                        EmailId = X.EmailId,
                        PhoneNumber = X.PhoneNumber,
                        address = new AddressModel()
                        {
                            state = X.address.state,
                            city = X.address.city,
                            Id = X.address.Id,
                        }
                    }).FirstOrDefault();
                return Result;
            }
        }


        public int EditEmployee(int Id, EmployeeModel model)
        {
            using (var Context = new EmpDBEntities())
            {
                var emp = new employee
                {
                    Id = model.Id,
                    Name = model.Name,
                    EmailId = model.EmailId,
                    AddressId = model.AddressId,
                    PhoneNumber = model.PhoneNumber
                };

                Context.Entry(emp).State = System.Data.Entity.EntityState.Modified;
                Context.SaveChanges();
                return emp.Id;
            }
        }

        public bool deleteEmployee(int Idt)
        {
            using (var Context = new EmpDBEntities())
            {
                var emp = new employee
                {
                    Id = Idt
                };
                Context.Entry(emp).State = System.Data.Entity.EntityState.Deleted;
                Context.SaveChanges();
                return false;
            }
        }
    }
}
