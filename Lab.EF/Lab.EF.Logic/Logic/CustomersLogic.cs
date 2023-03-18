using Lab.EF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace Lab.EF.Logic.Logic
{
    internal class CustomersLogic : BaseLogic, IABMLogic<Customers, string>
    {
        public List<Customers> GetAll()
        {
            try
            {
                return context.Customers.AsNoTracking().ToList();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error de incoporación Customers {ex.Message} , {ex.StackTrace}");
            }
        }
        public void Add(Customers x)
        {
            try
            {
                context.Customers.Add(x);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error Add Customers {ex.Message} , {ex.StackTrace}");
            }
        }

        public void Delete(Customers x)
        {
            try
            {
                Customers customers = context.Customers.FirstOrDefault<Customers>(s => s.CustomerID == x.CustomerID);
                if (customers != null)
                {
                    List<Orders> order = customers.Orders.ToList();
                    order.ForEach(or => or.Customers = null);
                    context.Customers.Remove(customers);
                    context.SaveChanges();
                }
                var customersDelete = context.Customers.Find(x);
                context.Customers.Remove(customersDelete);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error Delete Customers {ex.Message} , {ex.StackTrace}");
            }
        }

        public bool Exist(string x)
        {
            try
            {
                return context.Customers.Any(s => s.CompanyName.ToLower().Trim() == x.ToLower().Trim());
            }
            catch (Exception ex)
            {
                throw new Exception($"Error de existencia Customers {ex.Message} , {ex.StackTrace}");
            }
        }

        public void Update(Customers x)
        {
            try
            {
                Customers customers = context.Customers.FirstOrDefault(s => s.CustomerID == x.CustomerID);
                customers.CompanyName = x.CompanyName;
                customers.ContactName = x.ContactName;
                customers.ContactTitle = x.ContactTitle;
                customers.Address = x.Address;
                customers.City = x.City;
                customers.Region = x.Region;
                customers.PostalCode = x.PostalCode;
                customers.Country = x.Country;
                customers.Phone = x.Phone;
                customers.Fax = x.Fax;
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error de actualización Customers {ex.Message} , {ex.StackTrace}");
            }
        }
    }
}
