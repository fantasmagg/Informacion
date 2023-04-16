﻿using portafolio.Models;
using SendGrid;
using SendGrid.Helpers.Mail;

namespace portafolio.Servicios
{
    public interface IServicioEmail
    {
        Task Enviar(ContactoViewModel contacto);
    }
    public class ServiciosEmailSendGrid : IServicioEmail
    {
        private readonly IConfiguration configuration;
        public ServiciosEmailSendGrid(IConfiguration configuration)
        {
            this.configuration = configuration;
        }   

        public async Task Enviar(ContactoViewModel contacto)
        {
            var apiKey = configuration.GetValue<string>("SENDGRID_API_KEY");
            var email = configuration.GetValue<string>("SENDGRID_FROM");
            var nombre = configuration.GetValue<string>("SENDGRID_NOMBRE");

            var cliente = new SendGridClient(apiKey);
            var from = new EmailAddress(email, nombre);

            var subject = $"Reporte: {contacto.nombre}";
            var to = new EmailAddress(email, nombre);
            var mensajeTextoPlano = contacto.mensaje;
            var contenidoHtml = $@"De: {contacto.nombre} -
            Email: {contacto.email} -
            Mensaje: {contacto.mensaje}";

            var singleEmail = MailHelper.CreateSingleEmail(from, to, subject, mensajeTextoPlano, contenidoHtml);
            var respuesta = await cliente.SendEmailAsync(singleEmail);


        }
    }
}
