using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfSoapService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    public class Service : IService
    {
        public System.Xml.Linq.XElement getAllUsers()
        {
            return new Controller.UsuarioController().getAllUsers();
        }

        public string getAllUsersJson()
        {
            return new Controller.UsuarioController().getAllUsersJson();
        }

        public System.Xml.Linq.XElement insertUserXml(System.Xml.Linq.XElement xml)
        {
            return new Controller.UsuarioController().insertUserXml(xml);
        }
    }
}
