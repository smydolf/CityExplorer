using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CityExplorer.DatabaseLayer;
using CityExplorer.Model;
using Ninject;

namespace CityExplorer.WebApi.Controllers
{
    public class DefaultController : Controller
    {

        public IRepository<Person> MyProperty { get; set; }

        // GET: Default

        [Inject]
        public DefaultController(IRepository<Person> pefr)
        {
            MyProperty = pefr;
        }

        public ActionResult Index()
        {
            return View();
        }
    }
}