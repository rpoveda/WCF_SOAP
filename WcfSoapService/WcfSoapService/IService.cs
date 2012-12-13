using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfSoapService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService
    {
        [OperationContract]
        System.Xml.Linq.XElement getAllUsers();

        [OperationContract]
        string getAllUsersJson();

        [OperationContract]
        System.Xml.Linq.XElement insertUserXml(System.Xml.Linq.XElement xml);

        // TODO: Add your service operations here
    }
}
