﻿using System.Web.Http;
using System.Web.OData.Routing;
using CityExplorer.Model;
using CityExplorer.WebApi.Controllers.BaseController;

namespace CityExplorer.WebApi.Controllers
{
    public class PersonController : BaseController<Person>
    {
        [ODataRoute("Person({key})/DateOfBirth")]
        public override IHttpActionResult GetEntityProperty(int key)
        {
            return base.GetEntityProperty(key);
        }
    }
}
