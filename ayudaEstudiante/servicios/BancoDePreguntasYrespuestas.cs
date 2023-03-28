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

            if (senderMensaje.MessageTextSend.Equals("hola", StringComparison.InvariantCultureIgnoreCase) )
            {
                return @"Hola Soy un bot un tanto limitado pero espero poder adudarte:
                        <br>Ver pesunl
                        <br>Duracion de Carreras
                        <br>Correos del itla
                        <br>Numeros de telefonos";
            }
            return "...";

        }

    }
}
