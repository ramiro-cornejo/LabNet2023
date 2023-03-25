using Lab.EF.Entities;
using Lab.EF.Logic.Logic;
using Lab.EF.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab.EF.MVC.Controllers
{
    public class SuppliersController : Controller
    {
        readonly SuppliersLogic suppliersLogic = new SuppliersLogic();
        // GET: Suppliers
        public ActionResult Index()
        {

            List<Suppliers> result = suppliersLogic.GetAll();
            List<SuppliersViewModel> suppliersView = result.Select(s => new SuppliersViewModel
            {
                SupplierID = s.SupplierID,
                CompanyName = s.CompanyName,
                ContactName = s.ContactName,
            }).ToList();
            return View(suppliersView);
        }
        public ActionResult Insert()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Insert(SuppliersViewModel suppliersView)
        {
            try
            {
                var supplierInsert = new Suppliers();
                {
                    supplierInsert.SupplierID = suppliersView.SupplierID;
                    supplierInsert.CompanyName = suppliersView.CompanyName;
                    supplierInsert.ContactName = suppliersView.ContactName;
                };
                if(ComprobarSp(supplierInsert))
                {
                    suppliersLogic.Add(supplierInsert);
                    return RedirectToAction("Index");   
                }
                else
                {
                    throw new Exception();
                }
            }
            catch(Exception ex)
            {
                return RedirectToAction("Index", "Error");
            }
        }
        public ActionResult Update()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Update(SuppliersViewModel suppliersView)
        {
            try
            {
                var supplierUpdate = new Suppliers
                {
                    SupplierID = suppliersView.SupplierID,
                    CompanyName = suppliersView.CompanyName,
                    ContactName = suppliersView.ContactName
                };
                if (ComprobarSp(supplierUpdate))
                {
                    suppliersLogic.Update(supplierUpdate);
                    return RedirectToAction("Index");
                }
                else
                {
                    throw new Exception();
                }
            }
            catch(Exception ex)
            { 
                return RedirectToAction("Index", "Error");
            }
        }
        public bool ComprobarSp(Suppliers suppliers)
        {
            if(!(suppliers.SupplierID.ToString().Any(char.IsDigit)))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}