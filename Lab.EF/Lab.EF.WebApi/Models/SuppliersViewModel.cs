using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab.EF.WebApi.Models
{
    public class SuppliersViewModel
    {
        public int SupplierID { get; set; }
        public string CompanyName { get; set; }
        public string ContactName { get; set; }

        public SuppliersViewModel() { }
    }
}