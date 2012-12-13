using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ClientRequestSoap.SoapService;

namespace ClientRequestSoap.Service
{
    public class Service
    {
        public dynamic getClients(string typeResponse)
        {
            switch (typeResponse)
            {
                case "json":
                    return new SoapService.Service().getAllUsersJson();
                case "xml":
                    return new SoapService.Service().getAllUsers().InnerXml;
                default:
                    return null;
            }
        }

        
    }
}