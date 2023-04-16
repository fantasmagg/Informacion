using ayudaEstudiante.Controllers;
using ayudaEstudiante.Models;
using Dapper;
using Microsoft.Data.SqlClient;
using System.Data;

namespace ayudaEstudiante.servicios
{
    public interface IRegistroConsultas
    {
        Task guardarUsuario(Registro registro);
        Task<int> validar(Registro tipoCuenta);
    }

    public class RegistroConsultas : IRegistroConsultas
    {
        private readonly IConfiguration configuration;
        private readonly ILogger<HomeController> logger;
        private readonly string ConnectionStrings;
        public RegistroConsultas( IConfiguration configuration, ILogger<HomeController> logger)
        {
            this.configuration = configuration;
            this.logger = logger;
            ConnectionStrings = configuration.GetConnectionString("DefaultConnection");
        }

        public async Task guardarUsuario(Registro registro)
        {
            using var connection = new SqlConnection(ConnectionStrings);
            var id = await connection.QueryFirstOrDefaultAsync<int>
                (@"INSERT INTO usuario (nombre, telefono, matricula, email, password, fotoUrl)
                VALUES(@Nombre, @Telefono, @Matricula, @Email, @Password, @FotoUrl); ", registro);
        }

        public async Task<int> validar(Registro tipoCuenta)
        {

            

            using var connetion = new SqlConnection(ConnectionStrings);

            // no usamos este por que vamos a usar un procedure en su lugar, si quieres saber que hace el proceduro o donde esta, esta en 
            //C:\curos\c#\baseDedatos proyecto2
            /*var id = await connetion.QuerySingleAsync<int>($@"insert into TiposCuentas (nombre,usuarioid,orden) values(@nombre,@usuarioid,0);
                                                 Select SCOPE_IDENTITY();",tipoCuenta);*/
            logger.LogInformation(tipoCuenta.Nombre+" "+tipoCuenta.Password);

            var id = await  connetion.QuerySingleAsync<int>("verificar_usuario", new { nombre= tipoCuenta.Nombre, password = tipoCuenta.Password}, commandType: CommandType.StoredProcedure);

            

            return id;
        }


    }
}
