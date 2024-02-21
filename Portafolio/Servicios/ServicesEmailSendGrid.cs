using Portafolio.Infrestructura;
using Portafolio.Models;
using SendGrid;
using SendGrid.Helpers.Mail;

namespace Portafolio.Servicios
{
    public class ServicesEmailSendGrid : IServiceEmailSendGrid
    {
        private readonly IConfiguration _configuration;

        public ServicesEmailSendGrid(IConfiguration configuration)
        {
            this._configuration = configuration;
        }

        public async Task Enviar(ContactoVM contactoVM)
        {
            var apiKey = _configuration.GetValue<string>("SENDGRID_API_KEY");
            var email = _configuration.GetValue<string>("SENDGRID_FROM");
            var nombre = _configuration.GetValue<string>("SENDGRID_NOBRE");

            var cliente = new SendGridClient(apiKey);
            var from = new EmailAddress(email, nombre);
            var subject = $"El cliente {contactoVM.Email} quiere contactarte";
            var to = new EmailAddress(email, nombre);
            var mensajeTexto = contactoVM.Mensaje;
            var contenidohtml = $@"De: {contactoVM.Nombre} - Email: {contactoVM.Email} - Mensaje: {contactoVM.Mensaje}";
            var singleEmail = MailHelper.CreateSingleEmail(from, to, subject, mensajeTexto, contenidohtml);
            var respuesta = await cliente.SendEmailAsync(singleEmail);
        }

    }
}
