using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace PuntoDeEncuentro.Controllers
{
    public class BorraController : Controller
    {
        //
        // GET: /Borra/

        public ActionResult Index()
        {
            PuntoDeEncuentro.Models.puntoencuentroEntities bd = new Models.puntoencuentroEntities();
            PuntoDeEncuentro.Models.tbevento n = new Models.tbevento();
            n.estado = 1;
            n.titulo = "-";
            bd.tbevento.Add(n);
            try
            {
                if (bd.SaveChanges() == 1)
                {
                    //correcto
                }
                else
                {
                    //errores en informacion
                }
            }
            catch
            {

            }
        }
    }
}
