using Lab.EF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.EF.Logic.Logic
{
    internal class ProductsLogic : BaseLogic, IABMLogic<Products, string>
    {
        public List<Products> GetAll()
        {
            try
            {
                return context.Products.AsNoTracking().ToList();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error de incoporación Products {ex.Message} , {ex.StackTrace}");
            }
        }
        public void Add(Products x)
        {
            try
            {
                context.Products.Add(x);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error Add Products {ex.Message} , {ex.StackTrace}");
            }
        }

        public void Delete(Products x)
        {
            try
            {
                Products products = context.Products.FirstOrDefault<Products>(s => s.ProductID == x.ProductID);
                if (products != null)
                {
                    List<Order_Details> order = products.Order_Details.ToList();
                    order.ForEach(or => or.Products = null);
                    context.Products.Remove(products);
                    context.SaveChanges();
                }
                var productsDelete = context.Products.Find(x);
                context.Products.Remove(productsDelete);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error Delete Products {ex.Message} , {ex.StackTrace}");
            }
        }

        public bool Exist(string x)
        {
            try
            {
                return context.Products.Any(s => s.ProductName.ToLower().Trim() == x.ToLower().Trim());
            }
            catch (Exception ex)
            {
                throw new Exception($"Error de existencia Products {ex.Message} , {ex.StackTrace}");
            }
        }

        public void Update(Products x)
        {
            try
            {
                Products products = context.Products.FirstOrDefault(s => s.ProductID == x.ProductID);
                products.ProductName = x.ProductName;
                products.QuantityPerUnit = x.QuantityPerUnit;
                products.UnitPrice = x.UnitPrice;
                products.UnitsInStock = x.UnitsInStock;
                products.UnitsOnOrder = x.UnitsOnOrder;
                products.ReorderLevel = x.ReorderLevel;
                products.Discontinued = x.Discontinued;

                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error de actualización Products {ex.Message} , {ex.StackTrace}");
            }
        }
    }
}
