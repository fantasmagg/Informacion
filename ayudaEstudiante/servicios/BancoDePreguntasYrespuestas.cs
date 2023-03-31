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
                senderMensaje.MessageTextSend.Equals("ola", StringComparison.InvariantCultureIgnoreCase) || 
                senderMensaje.MessageTextSend.Equals("hol", StringComparison.InvariantCultureIgnoreCase) || 
                senderMensaje.MessageTextSend.Equals("hi", StringComparison.InvariantCultureIgnoreCase) || 
                senderMensaje.MessageTextSend.Equals("hello", StringComparison.InvariantCultureIgnoreCase) || 
                senderMensaje.MessageTextSend.Equals("holasss", StringComparison.InvariantCultureIgnoreCase)
                )
            {
                return @"Hola Soy un bot un tanto limitado pero espero poder adudarte:
                        <br>1 Ver pensum
                        <br>Duracion de Carreras
                        <br>Correos del itla
                        <br>Numeros de telefonos";
            }

            if (senderMensaje.MessageTextSend.Equals("Ver pensum", StringComparison.InvariantCultureIgnoreCase) || 
                senderMensaje.MessageTextSend.Equals("1", StringComparison.InvariantCultureIgnoreCase)||
                senderMensaje.MessageTextSend.Equals("ver pensum", StringComparison.InvariantCultureIgnoreCase) ||
                senderMensaje.MessageTextSend.Equals("ber pensul", StringComparison.InvariantCultureIgnoreCase) ||
                senderMensaje.MessageTextSend.Equals("pensul", StringComparison.InvariantCultureIgnoreCase) ||
                senderMensaje.MessageTextSend.Equals("pensum", StringComparison.InvariantCultureIgnoreCase)
                
                )
            {
                return @"<a class='ss' href='https://itla.edu.do/images/pdf/pensum-seguridad-informatica-2020.pdf'  target='_blank' rel='alternate noreferrer'>Segurida</a>";
            }


            return "...";

        }

    }
}
