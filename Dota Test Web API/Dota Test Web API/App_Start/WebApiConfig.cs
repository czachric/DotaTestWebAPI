using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace Dota_Test_Web_API
{
	public static class WebApiConfig
	{
		public static void Register(HttpConfiguration config)
		{
			config.Routes.MapHttpRoute(
				name: "DefaultApi",
				routeTemplate: "api/{controller}/{id}",
				defaults: new { id = RouteParameter.Optional }
			);


			//This causes the JSON to be the default return of API instead of XML
			//User can still specify for xml by passing "text/xml" as the request Accept header
			var appXmlType = config.Formatters.XmlFormatter.SupportedMediaTypes.FirstOrDefault(t => t.MediaType == "application/xml");
			config.Formatters.XmlFormatter.SupportedMediaTypes.Remove(appXmlType);
		}
	}
}
