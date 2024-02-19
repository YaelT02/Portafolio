using Portafolio.Infrestructura;
using Portafolio.Models;

namespace Portafolio.Servicios
{
    public class RepositorioServicios : IRepositorioServicios
    {
        public List<Proyecto> GetProyectos()
        {
            return new List<Proyecto>()
            {
                new Proyecto{Titulo="Amazon", Descripcion="E-commerce desarrollado en Net Core", Link="https://amazon.com", ImagenURL="/img/amazon.png"},
                new Proyecto{Titulo="Mercado libre", Descripcion="E-commerce con iumplementacion en JavaScript", Link="https://www.mercadolibre.com.mx", ImagenURL="/img/mercadolibre.jpg"},
                new Proyecto{Titulo="Twilio", Descripcion="Administracion y envio de de Emails", Link="https://www.twilio.com/es-mx", ImagenURL="/img/twilio.png"},
                new Proyecto{Titulo="Microsoft", Descripcion="Plataforma de aprendizaje Big-Learn", Link="https://www.microsoft.com/es-mx/", ImagenURL="/img/microsoft.png"},
            };
        }
    }
}
