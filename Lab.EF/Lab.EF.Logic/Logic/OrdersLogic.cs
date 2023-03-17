using Lab.EF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.EF.Logic.Logic
{
    public class OrdersLogic : BaseLogic, IABMLogic<Orders, string>
    {
        public List<Orders> GetAll()
        {
            try
            {
                return context.Orders.AsNoTracking().ToList();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error de incoporación Orders {ex.Message} , {ex.StackTrace}");
            }
        }
        public void Add(Orders x)
        {
            try
            {
                context.Orders.Add(x);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error Add Orders {ex.Message} , {ex.StackTrace}");
            }
        }

        public void Delete(Orders x)
        {
            try
            {
                Orders orders = context.Orders.FirstOrDefault<Orders>(s => s.OrderID == x.OrderID);
                if (orders != null)
                {
                    List<Order_Details> order = orders.Order_Details.ToList();
                    order.ForEach(or => or.Orders = null);
                    context.Orders.Remove(orders);
                    context.SaveChanges();
                }
                var ordersDelete = context.Orders.Find(x);
                context.Orders.Remove(ordersDelete);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error Delete Orders {ex.Message} , {ex.StackTrace}");
            }
        }

        public bool Exist(string x)
        {
            try
            {
                return context.Orders.Any(s => s.ShipName.ToLower().Trim() == x.ToLower().Trim());
            }
            catch (Exception ex)
            {
                throw new Exception($"Error de existencia Orders {ex.Message} , {ex.StackTrace}");
            }
        }

        public void Update(Orders x)
        {
            try
            {
                Orders orders = context.Orders.FirstOrDefault(s => s.OrderID == x.OrderID);
                orders.OrderDate = DateTime.Now;
                orders.RequiredDate = DateTime.Now;
                orders.ShippedDate = DateTime.Now;
                orders.Freight = 0;
                orders.ShipVia = 1;
                orders.ShipName = x.ShipName;
                orders.ShipAddress = x.ShipAddress;
                orders.ShipCity = x.ShipCity;
                orders.ShipRegion = x.ShipRegion;
                orders.ShipPostalCode = x.ShipPostalCode;
                orders.ShipCountry = x.ShipCountry;

                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error de actualización Orders {ex.Message} , {ex.StackTrace}");
            }
        }
    }
}
