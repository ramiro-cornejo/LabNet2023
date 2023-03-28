using Lab.EF.Entities;
using Lab.EF.Logic.Logic;
using Lab.EF.WebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Mvc;
using HttpGetAttribute = System.Web.Http.HttpGetAttribute;
using HttpPostAttribute = System.Web.Http.HttpPostAttribute;

namespace Lab.EF.WebApi.Controllers
{
    [EnableCors("*","*","*")]
    public class SuppliersController : ApiController
    {
        readonly SuppliersLogic suppliersLogic = new SuppliersLogic();

        public SuppliersController()
        {
            suppliersLogic = new SuppliersLogic();
        }

        [HttpGet]
        public IHttpActionResult Get()
        {
            try
            {
                var suppliers = suppliersLogic.GetAll();
                var suppliersViewModel = new List<SuppliersViewModel>();
                
                foreach(var supplier in suppliers)
                {
                    var supplierModel = new SuppliersViewModel
                    {
                        SupplierID = supplier.SupplierID,
                        CompanyName = supplier.CompanyName,
                        ContactName = supplier.ContactName,
                    };
                    suppliersViewModel.Add(supplierModel);
                }
                return Ok(suppliersViewModel);
            }
            catch(Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPost]
        public IHttpActionResult Post([FromBody] SuppliersViewModel suppliersViewModel)
        {
            try
            {
                if(!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                var supplier = new Suppliers
                {
                    CompanyName = suppliersViewModel.CompanyName,
                    ContactName= suppliersViewModel.ContactName,
                };

                suppliersLogic.Add(supplier);
                supplier.SupplierID = suppliersViewModel.SupplierID;

                return CreatedAtRoute("DefaultApi", new { id = supplier.SupplierID }, suppliersViewModel);
            }
            catch(Exception ex)
            {
                return InternalServerError(ex);
            }
        }
    }
}
