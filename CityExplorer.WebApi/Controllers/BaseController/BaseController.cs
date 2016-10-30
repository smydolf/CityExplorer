using System;
using System.Linq;
using System.Net;
using System.Web.Http;
using CityExplorer.DatabaseLayer;
using System.Web.OData;
using CityExplorer.Model;
using CityExplorer.WebApi.Extension;
using CityExplorer.WebApi.Interfaces;


namespace CityExplorer.WebApi.Controllers.BaseController
{
    public class BaseController<T> : ODataController, IBaseController<T> where T : class
    {
        public readonly IRepository<T> _repository = new Repository<T>();

        public IHttpActionResult Get()
        {
            return Ok(_repository.GetList());
        }
        public IHttpActionResult Post(T entity)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _repository.AddEntity(entity);
            _repository.SaveChange();
            return Created(entity);
        }
        public IHttpActionResult Get([FromODataUri]int key)
        {
            T result = _repository.GetEntityById(key);
            if (result == null) return NotFound();
            return Ok(result);
        }
        public virtual IHttpActionResult GetEntityProperty([FromODataUri]int key)
        {
            var entity = _repository.GetEntityById(key);
            if (entity == null) return NotFound();
            var propertyToGet = Url.Request.RequestUri.Segments.Last();
            if (!entity.HasProperty(propertyToGet)) return NotFound();
            var propertyValue = entity.GetValue(propertyToGet);
            return propertyValue == null
                ? StatusCode(HttpStatusCode.NoContent)
                : this.CreateOKHttpActionResult(propertyValue);
        }
        public IHttpActionResult Delete(int key)
        {
            return null;
        }
    }
}
