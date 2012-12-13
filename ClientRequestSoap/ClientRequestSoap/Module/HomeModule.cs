using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Nancy;

namespace ClientRequestSoap.Module
{
    public class HomeModule : NancyModule
    {
        public HomeModule()
        {
            Get["/{type?}"] = parameters =>
            {
                var type = !string.IsNullOrEmpty(parameters["type"]) ? parameters["type"] : Request.Query["type"];
                ViewBag["ResponseSOAP"] = new ClientRequestSoap.Service.Service().getClients(type);
                var t = new SoapService.Service().insertUserXml(null);
                return View["Index"];
            };

            Post["/teste/{type}"] = parameters =>
            {
                Nancy.Json.JsonSettings.MaxJsonLength = 5000000;
                String t = new ClientRequestSoap.Service.Service().getClients(parameters["type"]);
                if(parameters["type"] == "json")
                    return Response.AsJson(t);
                else
                    return Response.AsXml(t);
            };

        }
    }
}