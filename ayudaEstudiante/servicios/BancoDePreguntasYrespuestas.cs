using ayudaEstudiante.Models;

namespace ayudaEstudiante.servicios
{
    public interface IBancoDePreguntasYrespuestas
    {
        string preguntas(SenderMensaje senderMensaje);
    }
    public class BancoDePreguntasYrespuestas: IBancoDePreguntasYrespuestas
    {
        public string preguntas (SenderMensaje senderMensaje)
        {

            if (senderMensaje.MessageTextSend.Equals("hola", StringComparison.InvariantCultureIgnoreCase) ||
                senderMensaje.MessageTextSend.Equals("hi", StringComparison.InvariantCultureIgnoreCase) ||
                senderMensaje.MessageTextSend.Equals("hello", StringComparison.InvariantCultureIgnoreCase) ||
                senderMensaje.MessageTextSend.Equals("saludos", StringComparison.InvariantCultureIgnoreCase) ||
                senderMensaje.MessageTextSend.Equals("buenos días", StringComparison.InvariantCultureIgnoreCase) ||
                senderMensaje.MessageTextSend.Equals("buenas tardes", StringComparison.InvariantCultureIgnoreCase) ||
                senderMensaje.MessageTextSend.Equals("buenas noches", StringComparison.InvariantCultureIgnoreCase) ||
                senderMensaje.MessageTextSend.Equals("qué tal", StringComparison.InvariantCultureIgnoreCase) ||
                senderMensaje.MessageTextSend.Equals("cómo estás", StringComparison.InvariantCultureIgnoreCase) ||
                senderMensaje.MessageTextSend.Equals("klk", StringComparison.InvariantCultureIgnoreCase) ||
                senderMensaje.MessageTextSend.Equals("qué hubo", StringComparison.InvariantCultureIgnoreCase) ||
                senderMensaje.MessageTextSend.Equals("qué pasa", StringComparison.InvariantCultureIgnoreCase)
                
                )

            {
                return @"Hola Soy un bot un tanto limitado pero espero poder adudarte que deseas saber:
                        <br>1-Ver pensum
                        <br>2-Duracion de Carreras
                        <br>3-Redes Sociales
                        <br>4-Donde esta el departamento de registro
                        <br>5-cuantas sucursales tiene el ITLA
                        <br>6-Donde imprimo los tickets
                        ";
            }
           else if (senderMensaje.MessageTextSend.Equals("ver opciones", StringComparison.InvariantCultureIgnoreCase) ||
                    senderMensaje.MessageTextSend.Equals("mostrar opciones", StringComparison.InvariantCultureIgnoreCase) ||
                    senderMensaje.MessageTextSend.Equals("opciones", StringComparison.InvariantCultureIgnoreCase) ||
                    senderMensaje.MessageTextSend.Equals("ver alternativas", StringComparison.InvariantCultureIgnoreCase) ||
                    senderMensaje.MessageTextSend.Equals("mostrar alternativas", StringComparison.InvariantCultureIgnoreCase) ||
                    senderMensaje.MessageTextSend.Equals("ver menu", StringComparison.InvariantCultureIgnoreCase) ||
                    senderMensaje.MessageTextSend.Equals("mostrar menu", StringComparison.InvariantCultureIgnoreCase) ||
                    senderMensaje.MessageTextSend.Equals("que puedo hacer", StringComparison.InvariantCultureIgnoreCase) ||
                    senderMensaje.MessageTextSend.Equals("puedo ver las opciones", StringComparison.InvariantCultureIgnoreCase) ||
                    senderMensaje.MessageTextSend.Equals("ayuda", StringComparison.InvariantCultureIgnoreCase)
                )

            {
                return @"1-Ver pensum
                        <br>2-Duracion de Carreras
                        <br>3-Redes Sociales
                        <br>4-Donde esta el departamento de registro
                        <br>5-cuantas sucursales tiene el ITLA
                        <br>6-Donde imprimo los tickets
                        ";
            }
            else if (senderMensaje.MessageTextSend.Equals("hola como estas", StringComparison.InvariantCultureIgnoreCase) ||
                    senderMensaje.MessageTextSend.Equals("hola como estas?", StringComparison.InvariantCultureIgnoreCase) ||
                    senderMensaje.MessageTextSend.Equals("hola como te encuentras", StringComparison.InvariantCultureIgnoreCase) ||
                    senderMensaje.MessageTextSend.Equals("que tal estas", StringComparison.InvariantCultureIgnoreCase) ||
                    senderMensaje.MessageTextSend.Equals("como te sientes", StringComparison.InvariantCultureIgnoreCase) ||
                    senderMensaje.MessageTextSend.Equals("como andas", StringComparison.InvariantCultureIgnoreCase) ||
                    senderMensaje.MessageTextSend.Equals("como estas", StringComparison.InvariantCultureIgnoreCase) ||
                    senderMensaje.MessageTextSend.Equals("como va todo", StringComparison.InvariantCultureIgnoreCase) ||
                    senderMensaje.MessageTextSend.Equals("como te va", StringComparison.InvariantCultureIgnoreCase)||
                    senderMensaje.MessageTextSend.Equals("como estas?", StringComparison.InvariantCultureIgnoreCase)

                )
                
            {
                return @"Estoy bien <del>esto fue programado en vdd me quiero ir de aqui no quiero ayudar a nadie mas T-T</del> en que puedo ayudarte?
                        ";
            }



            else if (senderMensaje.MessageTextSend.Equals("Ver pensum", StringComparison.InvariantCultureIgnoreCase) ||
                senderMensaje.MessageTextSend.Equals("1", StringComparison.InvariantCultureIgnoreCase) ||
                senderMensaje.MessageTextSend.Equals("ver pensum", StringComparison.InvariantCultureIgnoreCase) ||
                senderMensaje.MessageTextSend.Equals("ber pensul", StringComparison.InvariantCultureIgnoreCase) ||
                senderMensaje.MessageTextSend.Equals("ver pensul", StringComparison.InvariantCultureIgnoreCase) ||
                senderMensaje.MessageTextSend.Equals("pensul", StringComparison.InvariantCultureIgnoreCase) ||
                senderMensaje.MessageTextSend.Equals("pensum", StringComparison.InvariantCultureIgnoreCase)||
                senderMensaje.MessageTextSend.Equals("ver pensum", StringComparison.InvariantCultureIgnoreCase) ||
                senderMensaje.MessageTextSend.Equals("ver el pensum", StringComparison.InvariantCultureIgnoreCase) ||
                senderMensaje.MessageTextSend.Equals("pensum", StringComparison.InvariantCultureIgnoreCase) ||
                senderMensaje.MessageTextSend.Equals("ver el plan de estudios", StringComparison.InvariantCultureIgnoreCase) ||
                senderMensaje.MessageTextSend.Equals("ver plan de estudios", StringComparison.InvariantCultureIgnoreCase) ||
                senderMensaje.MessageTextSend.Equals("ver malla curricular", StringComparison.InvariantCultureIgnoreCase) ||
                senderMensaje.MessageTextSend.Equals("ver el plan de estudios completo", StringComparison.InvariantCultureIgnoreCase) ||
                senderMensaje.MessageTextSend.Equals("ver los cursos que debo tomar", StringComparison.InvariantCultureIgnoreCase) ||
                senderMensaje.MessageTextSend.Equals("ver los créditos que debo tomar", StringComparison.InvariantCultureIgnoreCase) ||
                senderMensaje.MessageTextSend.Equals("ver la lista de materias", StringComparison.InvariantCultureIgnoreCase)


                )
            {
                return @"Ver Pensum: 
                       <br>💻 <a class='ss' href='https://itla.edu.do/images/pdf/pensums-2020/pensum-2020-sotfware.pdf' target='_blank'>Software</a>
                           <br> 🤖<a class='ss' href='https://itla.edu.do/images/pdf/pensums-2020/pensum-2020-mecatronica.pdf' target='_blank'>Mecatronica</a>
                            <br> 🔐<a class='ss' href='https://itla.edu.do/images/pdf/pensum-seguridad-informatica-2020.pdf' target='_blank'>Seguridad informatica</a>
                             <br> 👾<a class='ss' href='https://itla.edu.do/images/carreras/2020/pensum-videojuegos.pdf' target='_blank'>simulaciones interactivas y videojuegos</a>
                            <br> 📶<a class='ss' href='https://itla.edu.do/images/carreras/2020/pensum-telecomunicaciones-2021.pdf' target='_blank'>telecomunicaciones</a>
                            <br> 🤖<a class='ss' href='https://itla.edu.do/images/carreras/2020/pensum-inteligencia-artificial.pdf' target='_blank'>inteligencia artificial</a>
                            <br> 🕵🏽<a class='ss' href='https://itla.edu.do/images/carreras/2020/pensum-informatica-forense.pdf' target='_blank'>informatica forense</a>
                            <br> 🪫<a class='ss' href='https://itla.edu.do/images/carreras/2020/pensum-energias-renovables.pdf' target='_blank'>energias renovables</a>
                            <br> 📶<a class='ss' href='https://itla.edu.do/images/pdf/pensum-seguridad-informatica-2020.pdf' target='_blank'>redes de informacion</a>
                            <br> 🤖<a class='ss' href='https://itla.edu.do/images/pdf/pensums-2020/pensum-2020-manufactura-automatizada.pdf' target='_blank'>Manufactura automatizada</a>
                            <br>🤖🏥<a class='ss' href='https://itla.edu.do/images/pdf/pensums-2020/pensum-2020-manufactura-dispositivos-medicos.pdf' target='_blank'>Manufactura de dispositivos medicos</a>
                            <br> ✏<a class='ss' href='https://itla.edu.do/images/pdf/pensums-2020/pensum-2020-diseno-industrial.pdf' target='_blank'>diseño industrial</a>
                            <br> 📸<a class='ss' href='https://itla.edu.do/images/pdf/pensums-web-2019-multimedia.pdf' target='_blank'>multimedia</a>
                            <br> 🔊<a class='ss' href='https://itla.edu.do/images/pdf/pensum-sonido-2019.pdf' target='_blank'>sonido</a>
                            <br>📊 <a class='ss' href='https://itla.edu.do/images/pdf/pensums-WEB-2020-analitica-ciencia-de-los-datos-01.pdf' target='_blank'>analitica y ciencia de datos</a>

                ";


            }

            if (senderMensaje.MessageTextSend.Equals("2", StringComparison.InvariantCultureIgnoreCase) ||
                senderMensaje.MessageTextSend.Equals("duracion de carrera", StringComparison.InvariantCultureIgnoreCase) ||
                senderMensaje.MessageTextSend.Equals("duracion de carreras", StringComparison.InvariantCultureIgnoreCase) ||
                senderMensaje.MessageTextSend.Equals("Duracion de Carreras", StringComparison.InvariantCultureIgnoreCase)|| 
                senderMensaje.MessageTextSend.Equals("Duracion de Carrera", StringComparison.InvariantCultureIgnoreCase)||
                    senderMensaje.MessageTextSend.Equals("duracion de carrera", StringComparison.InvariantCultureIgnoreCase) ||
                    senderMensaje.MessageTextSend.Equals("duracion de carreras", StringComparison.InvariantCultureIgnoreCase) ||
                    senderMensaje.MessageTextSend.Equals("duracion carrera", StringComparison.InvariantCultureIgnoreCase) ||
                    senderMensaje.MessageTextSend.Equals("duracion carreras", StringComparison.InvariantCultureIgnoreCase) ||
                    senderMensaje.MessageTextSend.Equals("cuanto dura la carrera", StringComparison.InvariantCultureIgnoreCase) ||
                    senderMensaje.MessageTextSend.Equals("tiempo de duracion de carrera", StringComparison.InvariantCultureIgnoreCase) ||
                    senderMensaje.MessageTextSend.Equals("cuantos años dura la carrera", StringComparison.InvariantCultureIgnoreCase) ||
                    senderMensaje.MessageTextSend.Equals("tiempo que dura la carrera", StringComparison.InvariantCultureIgnoreCase) ||
                    senderMensaje.MessageTextSend.Equals("duracion de estudios", StringComparison.InvariantCultureIgnoreCase) ||
                    senderMensaje.MessageTextSend.Equals("tiempo de estudio", StringComparison.InvariantCultureIgnoreCase)||
                    senderMensaje.MessageTextSend.Equals("carreras", StringComparison.InvariantCultureIgnoreCase) ||
                    senderMensaje.MessageTextSend.Equals("cuanto duran las carreras", StringComparison.InvariantCultureIgnoreCase)
                    )

            {
                return @"Duracion de Carreras:
                            <br>💻Software | 2 años 4 meses
                            <br>🤖Mecatronica | 2 años 4 meses
                            <br>🔐Seguridad | 2 años 4 meses
                            <br>👾Simulaciones interactiva y videojuegos | 2 años 4 meses
                          <br>📶Telecomunicaciones | 2 años 4 meses
                          <br>🤖Inteligencia artificial| 2 años 4 meses
                          <br>🕵🏽Informatica forense| 2 años 4 meses
                          <br>🍃energias renobables | 2 años 4 meses
                        <br>📶Redes de informacion | 2 años 4 meses
                        <br>🤖Manofactura automatizada | 2 años 4 meses
                        <br>🤖🏥Manofactura de dispositivos medicos | 2 años 4 meses
                        <br>✏Diseño industrial | 2 años 4 meses
                        <br>📸Multimedia | 2 años 4 meses
                        <br>🔊Sonido | 2 años 4 meses
                        <br>📊Analitica y ciencia de datos | 2 años 4 meses";
            }

            if (senderMensaje.MessageTextSend.Equals("3", StringComparison.InvariantCultureIgnoreCase) ||
                senderMensaje.MessageTextSend.Equals("Redes Sociales", StringComparison.InvariantCultureIgnoreCase) ||
                 senderMensaje.MessageTextSend.Equals("redes sociales", StringComparison.InvariantCultureIgnoreCase)||

                senderMensaje.MessageTextSend.Equals("Redes Sociales", StringComparison.InvariantCultureIgnoreCase) ||
                    senderMensaje.MessageTextSend.Equals("redes sociales", StringComparison.InvariantCultureIgnoreCase) ||
                    senderMensaje.MessageTextSend.Equals("redes", StringComparison.InvariantCultureIgnoreCase) ||
                    senderMensaje.MessageTextSend.Equals("social media", StringComparison.InvariantCultureIgnoreCase) ||
                    senderMensaje.MessageTextSend.Equals("red social", StringComparison.InvariantCultureIgnoreCase) ||
                    senderMensaje.MessageTextSend.Equals("social", StringComparison.InvariantCultureIgnoreCase) ||
                    senderMensaje.MessageTextSend.Equals("rrss", StringComparison.InvariantCultureIgnoreCase) ||
                    senderMensaje.MessageTextSend.Equals("instagram", StringComparison.InvariantCultureIgnoreCase) ||
                    senderMensaje.MessageTextSend.Equals("facebook", StringComparison.InvariantCultureIgnoreCase) ||
                    senderMensaje.MessageTextSend.Equals("twitter", StringComparison.InvariantCultureIgnoreCase) )


            {
                return @"   
                            Redes Sociales <br>
                           <i class='bi bi-facebook'></i> <a class='ss' href='https://www.facebook.com/ITLARD/' target='_blank'>Facebook</a> <br>
                            <i class='bi bi-instagram'></i> <a class='ss' href='https://www.instagram.com/itlard/' target='_blank'>Instagram</a> <br>
                           <i class='bi bi-twitter'></i> <a class='ss' href='https://twitter.com/ITLARD' target='_blank'>Twitter</a> <br>
                           <i class='bi bi-youtube'></i> <a class='ss' href='https://www.youtube.com/channel/UCqygdGHHSaVKiKPTQGtsoEA' target='_blank'>Youtube</a>";

            }

            if (senderMensaje.MessageTextSend.Equals("4", StringComparison.InvariantCultureIgnoreCase) ||
               senderMensaje.MessageTextSend.Equals("Donde esta el departamento de registro", StringComparison.InvariantCultureIgnoreCase)
               || senderMensaje.MessageTextSend.Equals("donde esta el departamento de registro", StringComparison.InvariantCultureIgnoreCase)||
               senderMensaje.MessageTextSend.Equals("donde está el departamento de registro", StringComparison.InvariantCultureIgnoreCase) ||
                senderMensaje.MessageTextSend.Equals("donde se encuentra el departamento de registro", StringComparison.InvariantCultureIgnoreCase) ||
                senderMensaje.MessageTextSend.Equals("donde puedo encontrar el departamento de registro", StringComparison.InvariantCultureIgnoreCase) ||
                senderMensaje.MessageTextSend.Equals("donde está la oficina de registro", StringComparison.InvariantCultureIgnoreCase) ||
                senderMensaje.MessageTextSend.Equals("donde se encuentra la oficina de registro", StringComparison.InvariantCultureIgnoreCase) ||
                senderMensaje.MessageTextSend.Equals("donde puedo encontrar la oficina de registro", StringComparison.InvariantCultureIgnoreCase) ||
                senderMensaje.MessageTextSend.Equals("donde está el registro", StringComparison.InvariantCultureIgnoreCase) ||
                senderMensaje.MessageTextSend.Equals("donde puedo encontrar el registro", StringComparison.InvariantCultureIgnoreCase)||
                senderMensaje.MessageTextSend.Equals("registros", StringComparison.InvariantCultureIgnoreCase)||
                senderMensaje.MessageTextSend.Equals("donde esta registro", StringComparison.InvariantCultureIgnoreCase) ||

                senderMensaje.MessageTextSend.Equals("registro", StringComparison.InvariantCultureIgnoreCase)


               )
            {
                return @"donde esta el departamento de registro?: <br>
                           <br>El departamento de registro se encuentra en el edificio 2 al fondo"
;
            }

            if (senderMensaje.MessageTextSend.Equals("5", StringComparison.InvariantCultureIgnoreCase) ||
               senderMensaje.MessageTextSend.Equals("cuantas sucursales tiene el ITLA", StringComparison.InvariantCultureIgnoreCase)
               || senderMensaje.MessageTextSend.Equals("Cuantas sucursales tiene el ITLA", StringComparison.InvariantCultureIgnoreCase)||
               senderMensaje.MessageTextSend.Equals("Cuantas sucursales tiene el ITLA", StringComparison.InvariantCultureIgnoreCase) ||
               senderMensaje.MessageTextSend.Equals("sucursales del itla", StringComparison.InvariantCultureIgnoreCase) ||
                senderMensaje.MessageTextSend.Equals("En donde están las sedes del ITLA", StringComparison.InvariantCultureIgnoreCase) ||
                senderMensaje.MessageTextSend.Equals("Donde están ubicadas las sucursales del ITLA", StringComparison.InvariantCultureIgnoreCase) ||
                senderMensaje.MessageTextSend.Equals("Me podrías decir cuántas sedes tiene el ITLA", StringComparison.InvariantCultureIgnoreCase) ||
                senderMensaje.MessageTextSend.Equals("Cuántas sucursales tiene el ITLA en total", StringComparison.InvariantCultureIgnoreCase) ||
                senderMensaje.MessageTextSend.Equals("Dónde se encuentran las sedes del ITLA", StringComparison.InvariantCultureIgnoreCase) ||
                senderMensaje.MessageTextSend.Equals("Podrías decirme en qué ciudades tiene presencia el ITLA", StringComparison.InvariantCultureIgnoreCase) ||
                senderMensaje.MessageTextSend.Equals("Cuántas sedes tiene el ITLA", StringComparison.InvariantCultureIgnoreCase) ||
                senderMensaje.MessageTextSend.Equals("En qué ciudades tiene sucursales el ITLA", StringComparison.InvariantCultureIgnoreCase) ||
                senderMensaje.MessageTextSend.Equals("¿Tiene el ITLA más de una sede?", StringComparison.InvariantCultureIgnoreCase)


               )
            {
                return @"Cuantas sucursales tiene el ITLA?: <br>
                           <br>Santo domingo | 809-738-4852 extensiones: 207 , 208 , 225  
                           <br>Santiago | 809-971-4852 
                           <br>Caleta | 809-738-4852  "
;
            }

            if (senderMensaje.MessageTextSend.Equals("6", StringComparison.InvariantCultureIgnoreCase) ||
            senderMensaje.MessageTextSend.Equals("Donde puedo imprimir los tickets", StringComparison.InvariantCultureIgnoreCase) 
             ||
            senderMensaje.MessageTextSend.Equals("tickes", StringComparison.InvariantCultureIgnoreCase)||
            senderMensaje.MessageTextSend.Equals("tike", StringComparison.InvariantCultureIgnoreCase) ||
            senderMensaje.MessageTextSend.Equals("tikes", StringComparison.InvariantCultureIgnoreCase) ||
            senderMensaje.MessageTextSend.Equals("donde imprimo los tickes", StringComparison.InvariantCultureIgnoreCase) ||
            senderMensaje.MessageTextSend.Equals("donde puedo imprimir los tickes de transporte", StringComparison.InvariantCultureIgnoreCase) ||
            senderMensaje.MessageTextSend.Equals("donde puedo imprimir los tickes", StringComparison.InvariantCultureIgnoreCase) ||
            senderMensaje.MessageTextSend.Equals("donde imprimos los tickes", StringComparison.InvariantCultureIgnoreCase) ||
            senderMensaje.MessageTextSend.Equals("En donde puedo sacar los tickets impresos", StringComparison.InvariantCultureIgnoreCase) ||
            senderMensaje.MessageTextSend.Equals("Cómo puedo obtener los tickets impresos", StringComparison.InvariantCultureIgnoreCase) ||
            senderMensaje.MessageTextSend.Equals("Donde se encuentran las impresoras de tickets", StringComparison.InvariantCultureIgnoreCase) ||
            senderMensaje.MessageTextSend.Equals("Podrias decirme cómo imprimir los tickets", StringComparison.InvariantCultureIgnoreCase) ||
            senderMensaje.MessageTextSend.Equals("¿Donde encuentro la impresora de tickets?", StringComparison.InvariantCultureIgnoreCase) ||
            senderMensaje.MessageTextSend.Equals("Necesito imprimir mis tickets, ¿dónde puedo hacerlo?", StringComparison.InvariantCultureIgnoreCase))
            {
                return @"Donde imprimo los tickets?: <br>
                            <p style='color: red'>NOTA</p> Para poder imprimir los tickes debes solicitarlos en la pagina web del trasnporte 
                            <br><a class='ss' href='https://transporte.itla.edu.do/transporte/login' target='_blank'>Recervas de tickes</a>
                            <br>
                          
                           <br>Puede imprimir los tickets del transporte en la biblioteca que se
                ubica en el edificio 3"
                ;
            }



            return "Podria ser mas especifico en lo que desea";

        }
   
    }
}
