using Lab.EF.Entities;
using Lab.EF.Logic.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.EF.Logic.Control
{
    public class LinqControl 
    {
        CustomersLogic customersLogic = new CustomersLogic();   
        ProductsLogic productsLogic = new ProductsLogic();
        OrdersLogic ordersLogic = new OrdersLogic();

        // Ejercicio 1
        public IEnumerable<Customers> GetCustomers()
        {
            var query = (from Customers in customersLogic.GetAll()
                         orderby Customers.CustomerID ascending
                         select Customers);

            return query;
        }

        // Ejercicio 2
        public IEnumerable<Products> GetProductsWithoutStock()
        {
            var query = (from Products in productsLogic.GetAll()
                         where Products.UnitsInStock == 0
                         orderby Products.ProductName ascending
                         select Products);

            return query;
        }

        // Ejercicio 3
        public IEnumerable<Products> GetProductsWithtStock3Units()
        {
            var query = productsLogic.GetAll().Where(p => p.UnitsInStock > 0 && p.UnitPrice >= 3)
                                              .OrderBy(p => p.ProductName)
                                              .Select(p => p);

            return query;
        }

        // Ejercicio 4
        public IEnumerable<Customers> GetCustomersRegionWA()
        {
            var query = customersLogic.GetAll().Where(c => c.Region == "WA")
                                               .OrderBy(c => c.ContactName)
                                               .Select(c => c);

            return query;
        }

        // Ejercicio 5
        public IEnumerable<Products> GetElementOrNull()
        {
            var query = productsLogic.GetAll().Where(p => p.ProductID == 789)
                                              .OrderBy(p => p.ProductName)
                                              .Select(p => p);

            return query;
        }

        // Ejercicio 6
        public IEnumerable<Customers> GetCustomersName()
        {
            var query = (from Customers in customersLogic.GetAll()
                         orderby Customers.ContactName ascending
                         select Customers);
            return query;
        }

        // Ejercicio 7
        public IEnumerable<Orders> GetJoinCustomersAndOrders()
        {
            DateTime date_1 = new DateTime(1997, 01, 01);
            var query = (from orders in ordersLogic.GetAll()
                         join customers in customersLogic.GetAll()
                         on orders.CustomerID equals customers.CustomerID
                         where customers.Region == "WA" && orders.OrderDate >= date_1
                         orderby orders.OrderID ascending
                         select orders);

            return query;
        }  
    }
}
