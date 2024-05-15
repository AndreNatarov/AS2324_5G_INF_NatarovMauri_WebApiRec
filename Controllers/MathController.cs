using Microsoft.AspNetCore.Mvc;

namespace AS2324_5G_INF_NatarovMauri_WebApiRec.Controllers
{
    public class MathController : Controller
    {
        //API per conversione da Celsius a Fahrenheit
        [HttpGet("GetCelsiusAFahrenheit")]
        public JsonResult GetCelsiusAFahrenheit(double tempCelsius)
        {
            return Json(new
            {
                temperaturaInCelius = tempCelsius + "°C",
                risultato = tempCelsius*9/5+32 + "°F",
                message = "Conversione eseguita",
                status = "OK"
            });
        }

        //API calcolo volume cilindro
        [HttpGet("GetVolumeCilindro")]
        public JsonResult GetVolumeCilindro(double raggio, double altezza)
        {
            if (raggio > 0 && altezza > 0)
            {
                return Json(new
                {
                    risultato = Math.PI*raggio*raggio*altezza,
                    message = "Calcolo del volume del cilindro eseguito",
                    status = "OK"
                });
            }
            else
            {
                return Json(new
                {
                    message = "Errore, valori inferiori al zero",
                    status = "KO"
                });
            }
            
        }
    }
}
