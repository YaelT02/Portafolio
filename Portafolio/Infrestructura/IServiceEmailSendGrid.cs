using Portafolio.Models;

namespace Portafolio.Infrestructura
{
    public interface IServiceEmailSendGrid
    {
        Task Enviar(ContactoVM contactoVM);
    }
}
