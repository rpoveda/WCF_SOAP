using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfSoapService.Model
{
    internal class Usuario
    {
        public int codigo { get; set; }
        public string nome { get; set; }
        public string sobrenome { get; set; }
        public string email { get; set; }
        public DateTime dtCadastrado { get; set; }
    }
}