using ayudaEstudiante.Controllers;
using ayudaEstudiante.Models;
using Dapper;
using Microsoft.Data.SqlClient;

namespace ayudaEstudiante.servicios
{
    public interface IRepocistorioMensajes
    {
        Task DeleteMensajes();
        Task guardarMensajes(SenderMensaje senderMensaje);
        Task<IEnumerable<SenderMensaje>> obtenerMensajes(int usuario);
    }
    public class RepocistorioMensajes : IRepocistorioMensajes
    {

        private readonly string ConnectionStrings;
        private readonly ILogger<HomeController> logger;
        private readonly IConfiguration configuration;

        public RepocistorioMensajes(ILogger<HomeController> logger, IConfiguration configuration)
        {
            this.logger = logger;
            ConnectionStrings = configuration.GetConnectionString("DefaultConnection");
        }

        public async Task guardarMensajes(SenderMensaje senderMensaje)
        {
            using var connection = new SqlConnection(ConnectionStrings);
            await connection.QueryAsync
                ("insert into mensajes (MessageText,MessageTextSend,Idu) values(@MessageText,@MessageTextSend,@Idu);", senderMensaje);
        }

        public async Task<IEnumerable<SenderMensaje>> obtenerMensajes(int usuario)
        {
            using var connection = new SqlConnection(ConnectionStrings);

            return await connection.QueryAsync<SenderMensaje>("SELECT MessageText , MessageTextSend from mensajes where idu =@usuario;" ,new { usuario });
        }

        public async Task DeleteMensajes()
        {
            using var connection = new SqlConnection(ConnectionStrings);

            await connection.ExecuteAsync("DELETE FROM mensajes;");
        }



    }
}
