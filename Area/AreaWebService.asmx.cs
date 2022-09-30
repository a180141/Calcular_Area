using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Area
{
    /// <summary>
    /// Descripción breve de AreaWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class AreaWebService : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hola a todos";
        }
        [WebMethod]
        public decimal cuadrado(decimal d1)
        {
            SacarArea s = new SacarArea();
            s.dato1 = d1;
            return s.cuadrado(d1);
        }
        [WebMethod]
        public decimal triangulo(decimal d1, decimal d2)
        {
            SacarArea s = new SacarArea();
            s.dato1 = d1;
            s.dato2 = d2;
            return s.triangulo(d1,d2);
        }
        [WebMethod]
        public double circulo(double d3)
        {
            SacarArea s = new SacarArea();
            s.dato3 = d3;
            return s.circulo(d3);
        }
    }
}
