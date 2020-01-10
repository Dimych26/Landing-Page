using DAL.Entities;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        readonly IProductService productservice;
        readonly IOrderService orderservice;
        readonly IQuestionSender questionSender;
        public HomeController(IProductService service, IOrderService order,IQuestionSender sender)
        {
            productservice = service;
            orderservice = order;
            questionSender = sender;
        }
        public ActionResult Index()
        {
           
            return View();
        }
        public ActionResult ListOfTown()
        {
            return View();
        }

        public ActionResult Send()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        public void Send(Order order,ProductViewModel model)
        {
           
            orderservice.MakeOrder(order, new Product { Name = model.Name, Color = model.Color, Price = model.Price });
           // return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult AskQuestion(Question question)
        {
            
            questionSender.AskQuestion(question);
            return RedirectToAction("Index");
        }

       

        public void Get()
        {
            var item = productservice.GetAllItem();
            foreach(var el in item)
            {
                ControllerContext.HttpContext.Response.Write(el.Name);
            }
        }
    }
}