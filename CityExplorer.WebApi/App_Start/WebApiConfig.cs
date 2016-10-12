using System.Web.Http;
using System.Web.OData.Builder;
using System.Web.OData.Extensions;
using CityExplorer.Model;
using Microsoft.OData.Edm;

namespace CityExplorer.WebApi
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.MapODataServiceRoute(
                  "ODataRoute",
                  "odata",
                  GetEdmModel());

            config.EnsureInitialized();
        }
        private static IEdmModel GetEdmModel()
        {
            var builder = new ODataConventionModelBuilder();
            builder.Namespace = "CityExplorer";
            builder.ContainerName = "CityExplorerlContainer";

            builder.EntitySet<Person>("Person");
            return builder.GetEdmModel();
        }
    }
}
