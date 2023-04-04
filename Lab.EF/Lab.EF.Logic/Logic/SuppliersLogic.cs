using Lab.EF.Data;
using Lab.EF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.EF.Logic.Logic
{
    public class SuppliersLogic : BaseLogic, IABMLogic<Suppliers,string>
    {
        public void Add(Suppliers x)
        {
            context.Suppliers.Add(x);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            var supplierToDelete = context.Suppliers.Find(id);
            if(supplierToDelete == null)
            {
                throw new ArgumentException($"Supplier con ID {id} no existente. ");
            }
            context.Suppliers.Remove(supplierToDelete);
            context.SaveChanges();
        }

        public List<Suppliers> GetAll()
        {
            return context.Suppliers.ToList();
        }

        public void Update(Suppliers x)
        {
            var supplierUpdate = context.Suppliers.Find(x.SupplierID);
            if(supplierUpdate == null)
            {
                throw new ArgumentException($"Supplier con ID {x.SupplierID} no existente.");
            }

            supplierUpdate.CompanyName = x.CompanyName;
            supplierUpdate.ContactName = x.ContactName;
            context.SaveChanges();
        }

        public Suppliers GetById(int id)
        {
            return context.Suppliers.FirstOrDefault(s => s.SupplierID == id);
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

        public void Delete()
        {
            throw new NotImplementedException();
        }
    }
}
