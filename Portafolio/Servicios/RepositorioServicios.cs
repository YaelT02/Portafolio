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
                new Proyecto{Titulo="PROLAMSA", Descripcion="Trabajo actual, organización enfocada en la elaboración de tubos de acero.", Link="https://www.prolamsa.com/", ImagenURL="/img/logo_prolamsa.png"},

                new Proyecto{Titulo="NOVA", Descripcion="Web App enfocada en el sistema de ahorro personal.", Link="https://www.facebook.com/profile.php?id=100091128860576&mibextid=ZbWKwL", ImagenURL="/img/NOVA.jpg"},

                new Proyecto{Titulo="Digital 5'S", Descripcion="Aplicación movil enfocada en la realización de auditorias enfocadas en el cumplimiento de la metodologia 5'S", Link="https://www.prolamsa.com/", ImagenURL="/img/Digital5S.png"},

                new Proyecto{Titulo="GitHub", Descripcion="Plataforma de desarrollo de software en línea que permite a los desarrolladores almacenar, supervisar y trabajar en proyectos de software.", Link="https://github.com/YaelT02/Portafolio", ImagenURL="/img/BannerGit.png"},
            };
        }
    }
}
