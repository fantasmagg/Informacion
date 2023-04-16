using ayudaEstudiante.Models;
using ayudaEstudiante.servicios;
using Microsoft.AspNetCore.Mvc;
using portafolio.Models;
using portafolio.Servicios;
using System.Diagnostics;

namespace ayudaEstudiante.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IServicioEmail servicioEmail;
        private readonly IRepocistorioMensajes repocistorioMensajes;
        private readonly IBancoDePreguntasYrespuestas bancoDePreguntasYrespuestas;
        private static int cantidad = 0;
        private static int yo = 0;
        public HomeController(ILogger<HomeController> logger, IServicioEmail servicioEmail, IRepocistorioMensajes repocistorioMensajes,
            IBancoDePreguntasYrespuestas bancoDePreguntasYrespuestas)
        {
            _logger = logger;
            this.servicioEmail = servicioEmail;
            this.repocistorioMensajes = repocistorioMensajes;
            this.bancoDePreguntasYrespuestas = bancoDePreguntasYrespuestas;

           

        }

        public async Task< IActionResult> Index()
        {
            if (yo == 0)
            {
                return View();
            }
            var datos = await repocistorioMensajes.obtenerMensajes(yo);
            return View("Indexs",datos);

        }
        public IActionResult Registrar()
        {

            return View();
        }



        public async Task<IActionResult> Indexs()
        {
            if (TempData.ContainsKey("Resgistro"))
            {
                yo = (int)TempData["Resgistro"];
            }

            var datos = await repocistorioMensajes.obtenerMensajes(yo);

            if(datos.Any())
            {
               
                return View(datos);
            }
            else
            {
                SenderMensaje senderMensaje = new SenderMensaje();

                
                senderMensaje.Idu = yo;
                var allas = senderMensaje.Idu;

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
        public async Task<IActionResult> Indexs(SenderMensaje senderMensaje)
        {
            _logger.LogInformation( "aaaaaaaaaaaaaaaaassssssssssssaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaas ");

            if (senderMensaje.MessageTextSend is null){
                cantidad = cantidad + 1;
                _logger.LogInformation(cantidad+" ");
                if (cantidad>5)
                {
                    await repocistorioMensajes.DeleteMensajes();
                    
                }
                if (TempData.ContainsKey("Resgistro"))
                {
                    yo = (int)TempData["Resgistro"];
                }
                senderMensaje.Idu = yo;
                var asas = senderMensaje.Idu;
                senderMensaje.MessageText = @"Podrias dejar de enviar mensajes vacios por favor";
                await repocistorioMensajes.guardarMensajes(senderMensaje);
                // Obtener todos los mensajes de la base de datos
                var datoss = await repocistorioMensajes.obtenerMensajes(yo);
                return View(datoss);
             
            }

            if (TempData.ContainsKey("Resgistro"))
            {
                yo = (int)TempData["Resgistro"];
            }



            senderMensaje.Idu=yo;

            if(senderMensaje.Idu == 0)
            {
                return RedirectToAction("Index","Secion");
            }

            senderMensaje.MessageText = bancoDePreguntasYrespuestas.preguntas(senderMensaje);



            var gg = senderMensaje.Idu;

            // Obtener la respuesta a partir del mensaje enviado
            _logger.LogInformation("aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"+yo);

            // Guardar el mensaje en la base de datos
            await repocistorioMensajes.guardarMensajes(senderMensaje);

            // Obtener todos los mensajes de la base de datos
            var datos = await repocistorioMensajes.obtenerMensajes(yo);

            // Devolver la vista con los datos
            cantidad = cantidad - 1;
            return View(datos);

        }

        [HttpPost]
        public async Task<IActionResult> CerrarPestana()
        {
            _logger.LogInformation("entroooooooooooo");
            await repocistorioMensajes.DeleteMensajes();
            SenderMensaje senderMensaje = new SenderMensaje();
            senderMensaje.MessageText = @"Hola, soy bot programado con estas opciones en las que te puedo ayudar
                                            en las que te puedo ayudar
                                               en las que te puedo ayudar";

            senderMensaje.Idu = yo;
            await repocistorioMensajes.guardarMensajes(senderMensaje);
            List<SenderMensaje> senderMensajes = new List<SenderMensaje>();
            senderMensajes.Add(senderMensaje);
            return View("Indexs",senderMensajes);
            
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult reporte()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> reporte(ContactoViewModel contactoViewModel)
        {
            await servicioEmail.Enviar(contactoViewModel);
            return RedirectToAction("Gracias");
        }
        public IActionResult Gracias()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


        public IActionResult login()
        {
            return View();
        }
    }
}