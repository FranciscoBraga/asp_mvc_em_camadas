using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Repository_Mvc_ApplicationLayer.ApplicationImplementation;
using Repository_Mvc_DataLayer.DataContext;
using Repository_Mvc_DataLayer.DataEntity;

namespace Repository_Mvc_Web.Controllers
{
    public class ProductsController : Controller
    {

        private ProductApplication productsApplication = new ProductApplication();

        // GET: Products
        public ActionResult Index()
        {
            var view = productsApplication.GetProduct();
            return View(view);
        }

        // GET: Products/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Erros/Http404.cshtml");
            }
            Product product = productsApplication.FindProduct(id);
            if (product == null)
            {
                return RedirectToAction("Erros/Http404.cshtml");
            }
            return View(product);
        }

        // GET: Products/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Products/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Weight,Price")] Product product)
        {
            if (ModelState.IsValid)
            {
                productsApplication.AddProduct(product);
                return RedirectToAction("Index");
            }

            return View(product);
        }

        // GET: Products/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return  RedirectToAction("Erros/Http404.cshtml");
            }
            Product product = productsApplication.FindProduct(id);
            if (product == null)
            {
                return RedirectToAction("Erros/Http404.cshtml");
            }
            return View(product);
        }

        // POST: Products/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Weight,Price")] Product product)
        {
            if (ModelState.IsValid)
            {
                productsApplication.UpdateProduct(product);
                return RedirectToAction("Index");
            }
            return View(product);
        }

        // GET: Products/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Erros/Http404.cshtml"); 
            }
            Product product = productsApplication.FindProduct(id);
            if (product == null)
            {
                return RedirectToAction("Erros/Http404.cshtml");
            }
            return View(product);
        }

        // POST: Products/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Product product = productsApplication.FindProduct(id);
            productsApplication.RemoveProduct(product);
            return RedirectToAction("Index");
        }

     
    }
}
