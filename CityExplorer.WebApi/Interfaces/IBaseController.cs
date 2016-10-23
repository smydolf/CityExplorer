using System.Web.Http;
using System.Web.OData;

namespace CityExplorer.WebApi.Interfaces
{
    public interface IBaseController<in T> where T : class
    {
        IHttpActionResult Get();
        IHttpActionResult Post(T entity);
        IHttpActionResult Get([FromODataUri] int key);
        IHttpActionResult GetEntityProperty([FromODataUri] int key);
        IHttpActionResult Delete([FromODataUri] int key);

    }
}
