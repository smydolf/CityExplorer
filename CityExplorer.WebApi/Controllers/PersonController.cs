using System.Web.Http;
using CityExplorer.DatabaseLayer;
using CityExplorer.Model;
using System.Web.OData;

namespace CityExplorer.WebApi.Controllers
{
    public class PersonController : ODataController
    {
        private readonly IRepository<Person> _repository = new Repository<Person>();

        public IHttpActionResult Get()
        {
            return Ok(_repository.GetList());
        }
    }
}
