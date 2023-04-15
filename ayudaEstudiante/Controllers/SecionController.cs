using ayudaEstudiante.Models;
using ayudaEstudiante.servicios;
using Microsoft.AspNetCore.Mvc;

namespace ayudaEstudiante.Controllers
{
    public class SecionController : Controller
    {
        private readonly ILogger<SecionController> logger;
        private readonly IRegistroConsultas registroConsultas;

        public SecionController(ILogger<SecionController> logger, IRegistroConsultas registroConsultas)
        {
            this.logger = logger;
            this.registroConsultas = registroConsultas;
        }


        [HttpPost]
        public async Task<IActionResult> validacion(Registro resgistro)
        {

            if(resgistro is null)
            {
                return RedirectToAction("Index", "Home");
            }

           

            var registrado =  await registroConsultas.validar(resgistro);

            if (registrado ==0)
            {

                return RedirectToAction("Index", "Home");
            }

            TempData["Resgistro"] = registrado;


            return RedirectToAction("Indexs", "Home");

        }


        [HttpPost]
        public async Task<IActionResult> guardar( Registro senderMensaje)
        {

           

            

            await registroConsultas.guardarUsuario(senderMensaje);
           
            return RedirectToAction("Index", "Home");

        }

    }
}
