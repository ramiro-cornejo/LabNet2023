using Lab.EF.Data;
using Lab.EF.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.EF.Logic
{
    public class ShippersLogic : BaseLogic, IABMLogic<Shippers, int>
    {
        public List<Shippers> GetAll()
        {
            return context.Shippers.ToList();
        }
        public void Add(Shippers item)
        {
            context.Shippers.Add(item);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            var shippersDelete = context.Shippers.FirstOrDefault(r => r.ShipperID == id);
            context.Shippers.Remove(shippersDelete);
            context.SaveChanges();
        }
        public void Update(Shippers item)
        {
            var shippersUpdate = context.Shippers.Find(item.ShipperID);

            shippersUpdate.CompanyName = item.CompanyName;
            shippersUpdate.Phone = item.Phone;
            context.SaveChanges();
        }
    }
}
