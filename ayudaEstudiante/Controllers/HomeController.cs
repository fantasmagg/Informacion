using ayudaEstudiante.Models;
using ayudaEstudiante.servicios;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ayudaEstudiante.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IRepocistorioMensajes repocistorioMensajes;
        private readonly IBancoDePreguntasYrespuestas bancoDePreguntasYrespuestas;

        public HomeController(ILogger<HomeController> logger, IRepocistorioMensajes repocistorioMensajes, IBancoDePreguntasYrespuestas bancoDePreguntasYrespuestas)
        {
            _logger = logger;
            this.repocistorioMensajes = repocistorioMensajes;
            this.bancoDePreguntasYrespuestas = bancoDePreguntasYrespuestas;
        }

        public async Task<IActionResult> Index()
        {
            var datos = await repocistorioMensajes.obtenerMensajes();

            if(datos.Any())
            {
                return View(datos);
            }
            else
            {
                SenderMensaje senderMensaje = new SenderMensaje();


                senderMensaje.MessageText = @"Hola, soy bot programado con estas opciones en las que te puedo ayudar
                                            en las que te puedo ayudar
                                               en las que te puedo ayudar";
                await repocistorioMensajes.guardarMensajes(senderMensaje);
                List<SenderMensaje> senderMensajes = new List<SenderMensaje>();
                senderMensajes.Add(senderMensaje);
                return View(senderMensajes);
            }

            

           

            
        }

        [HttpPost]
        public async Task<IActionResult> Index(SenderMensaje senderMensaje)
        {

            if (string.IsNullOrEmpty(senderMensaje.MessageTextSend)){

                return View();
            }

            senderMensaje.MessageText = bancoDePreguntasYrespuestas.preguntas(senderMensaje);

            

            // Obtener la respuesta a partir del mensaje enviado


            // Guardar el mensaje en la base de datos
            await repocistorioMensajes.guardarMensajes(senderMensaje);

            // Obtener todos los mensajes de la base de datos
            var datos = await repocistorioMensajes.obtenerMensajes();

            // Devolver la vista con los datos
            return View(datos);

        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}