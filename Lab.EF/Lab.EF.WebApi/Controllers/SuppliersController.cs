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

namespace Lab.EF.WebApi.Controllers
{
    [EnableCors(origins: "http://localhost:4200", headers: "*" , methods: "*")]
    public class SuppliersController : ApiController
    {
        private readonly SuppliersLogic _supplierLogic = new SuppliersLogic();
        public IEnumerable<Suppliers> Get()
        {
            return _supplierLogic.GetAll();
        }

        public Suppliers Get(int id)
        {
            return _supplierLogic.GetById(id);
        }

        public HttpResponseMessage Post([FromBody] Suppliers suppliers)
        {
            try
            {
                if(string.IsNullOrEmpty(suppliers.CompanyName) || string.IsNullOrEmpty(suppliers.ContactName))
                {
                    throw new ArgumentException("CompanyName y ContactName son requeridos.");
                }
                _supplierLogic.Add(suppliers);

                return Request.CreateResponse(HttpStatusCode.Created, suppliers);
            }
            catch(ArgumentException ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        [HttpPut]
        public IHttpActionResult Put(int id, [FromBody] Suppliers suppliers)
        {
            try
            {
                if(suppliers == null || suppliers.SupplierID != 0)
                {
                    throw new ArgumentException("SupplierID no coincide con el recibido.");
                }

                var existSupplier = _supplierLogic.GetById(id);
                if (existSupplier == null)
                {
                    throw new ArgumentException($"Supplier con ID {id} no existente.");
                }

                existSupplier.CompanyName = suppliers.CompanyName;
                existSupplier.ContactName = suppliers.ContactName;
                _supplierLogic.Update(existSupplier);

                return Ok();
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            try
            {
                var logica = new SuppliersLogic();
                logica.Delete(id);
                return Ok();
            }
            catch(ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
