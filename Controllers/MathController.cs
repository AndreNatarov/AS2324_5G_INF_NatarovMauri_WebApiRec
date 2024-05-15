using Microsoft.AspNetCore.Mvc;

namespace AS2324_5G_INF_NatarovMauri_WebApiRec.Controllers
{
    public class MathController : Controller
    {
        //API per conversione da Celsius a Fahrenheit

        //API calcolo volume cilindro
        [HttpGet("GetVolumeCilindro")]
        public JsonResult GetVolumeCilindro(double raggio, double altezza)
        {
            if (raggio > 0 && altezza > 0)
            {
                return Json(new
                {
                    risultato = Math.PI*raggio*raggio*altezza,
                    message = "",
                    status = "OK"
                });
            }
            
        }
    }
}
