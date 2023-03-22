using Lab.EF.Data;
using Lab.EF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.EF.Logic.Logic
{
    public class SuppliersLogic : BaseLogic, IABMLogic<Suppliers, string>
    {


        public List<Suppliers> GetAll()
        {
            try
            {
                return context.Suppliers.AsNoTracking().ToList();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error de incoporación {ex.Message} -- {ex.StackTrace}");
            }
        }

        public void Add(Suppliers x)
        {
            try
            {
                context.Suppliers.Add(x);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error Add Suppliers {ex.Message} -- {ex.StackTrace}");
            }
        }

        public void Update(Suppliers x)
        {
            try
            {
                Suppliers SP = context.Suppliers.FirstOrDefault(s => s.SupplierID == x.SupplierID);
                SP.CompanyName = x.CompanyName;
                SP.ContactName = x.ContactName;
                SP.ContactTitle = x.ContactTitle;
                SP.City = x.City;
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error de actualización Suppliers {ex.Message} -- {ex.StackTrace}");
            }

        }
        public void Delete(Suppliers x)
        {
            try
            {

                Suppliers SP = context.Suppliers.FirstOrDefault<Suppliers>(s => s.SupplierID == x.SupplierID);
                if (SP != null)
                {
                    List<Products> PR = SP.Products.ToList();
                    PR.ForEach(pr => pr.SupplierID = null);
                    context.Suppliers.Remove(SP);
                    context.SaveChanges();
                }

            }
            catch (Exception ex)
            {

                throw new Exception($"Error Delete Suppliers {ex.Message} -- {ex.StackTrace}");
            }
        }

        public bool Exist(string x)
        {

            try
            {
                return context.Suppliers.Any(s => s.CompanyName.ToLower().Trim() == x.ToLower().Trim());
            }
            catch (Exception ex)
            {
                throw new Exception($"Error de existencia Suppliers {ex.Message} -- {ex.StackTrace}");
            }

        }
    }
}
