using ayudaEstudiante.Controllers;
using ayudaEstudiante.Models;
using Dapper;
using Microsoft.Data.SqlClient;

namespace ayudaEstudiante.servicios
{
    public interface IRepocistorioMensajes
    {
        Task guardarMensajes(SenderMensaje senderMensaje);
        Task<IEnumerable<SenderMensaje>> obtenerMensajes();
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
            var id = await connection.QueryFirstOrDefaultAsync<int>
                ("insert into mensajes (MessageText,MessageTextSend) values(@MessageText,@MessageTextSend);",senderMensaje);
        }

        public async Task<IEnumerable<SenderMensaje>> obtenerMensajes()
        {
            using var connection = new SqlConnection(ConnectionStrings);

            return await connection.QueryAsync<SenderMensaje>("SELECT MessageText , MessageTextSend from mensajes;");
        }



    }
}
