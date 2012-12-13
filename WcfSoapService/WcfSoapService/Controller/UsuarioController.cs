using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace WcfSoapService.Controller
{
    sealed public class UsuarioController
    {
        public XElement getAllUsers()
        {
            var xml = new XElement("Usuarios",
                listUsuario().Select(o => new XElement("usuario",
                new XElement("codigo", o.codigo),
                new XElement("nome", o.nome),
                new XElement("sobrenome", o.sobrenome),
                new XElement("email", o.email),
                new XElement("dtCadastrado", o.dtCadastrado))));

            return xml;
        }

        public string getAllUsersJson()
        {
            System.Web.Script.Serialization.JavaScriptSerializer jsSerializer = new System.Web.Script.Serialization.JavaScriptSerializer();
            jsSerializer.MaxJsonLength = 5000000;
            String json = jsSerializer.Serialize(listUsuario());
            return json;
        }

        public XElement insertUserXml(XElement xml)
        {
            try
            {
                return new XElement("retorno-insert", new XElement("msg", "successo"));
            }
            catch (Exception e)
            {
                return new XElement("retorno-insert", new XElement("msg", "error"), new XElement("return", e.Message));
            }
        }

        private List<Model.Usuario> listUsuario()
        {
            List<Model.Usuario> _lst = new List<Model.Usuario>();
            for (int i = 0; i < 10000; i++)
            {
                _lst.Add(new Model.Usuario { codigo = i, nome = "Usuario" + i, sobrenome = "Sobrenome" + i, email = "email" + i + "@email.com", dtCadastrado = DateTime.Now });
            }
            return _lst;
        }
    }
}