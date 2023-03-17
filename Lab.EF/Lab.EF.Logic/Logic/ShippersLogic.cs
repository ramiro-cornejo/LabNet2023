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
    public class ShippersLogic : BaseLogic, IABMLogic<Shippers, string>
    {
        public List<Shippers> GetAll()
        {
            try
            {
                return context.Shippers.AsNoTracking().ToList();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error de incoporación Shippers {ex.Message} , {ex.StackTrace}");
            }
        }
        public void Add(Shippers x)
        {
            try
            {
                context.Shippers.Add(x);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error Add Shippers {ex.Message} , {ex.StackTrace}");
            }
        }

        public void Delete(Shippers x)
        {
            try
            {
                Shippers shippers = context.Shippers.FirstOrDefault<Shippers>(s => s.ShipperID == x.ShipperID);
                if (shippers != null)
                {
                    List<Orders> order = shippers.Orders.ToList();
                    order.ForEach(or => or.Shippers = null);
                    context.Shippers.Remove(shippers);
                    context.SaveChanges();
                }
                var shippersDelete = context.Shippers.Find(x);
                context.Shippers.Remove(shippersDelete);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error Delete Shippers {ex.Message} , {ex.StackTrace}");
            }
        }

        public bool Exist(string x)
        {
            try
            {
                return context.Shippers.Any(s => s.CompanyName.ToLower().Trim() == x.ToLower().Trim());
            }
            catch (Exception ex)
            {
                throw new Exception($"Error de existencia Shippers {ex.Message} , {ex.StackTrace}");
            }
        }

        public void Update(Shippers x)
        {
            try
            {
                Shippers shippers = context.Shippers.FirstOrDefault(s => s.ShipperID == x.ShipperID);
                shippers.CompanyName = x.CompanyName;
                shippers.Phone = x.Phone;
                shippers.Orders = x.Orders;
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error de actualización Shippers {ex.Message} , {ex.StackTrace}");
            }
        }
    }
}

