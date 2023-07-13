using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IVehiculos
    {
        int ID { get; set; }
        string Tipo { get; set; }
        string Marca { get; set; }
        string Modelo { get; set; }
        double TiempoDeAceleracion_segundosPor100kmH { get; set; }
        double VelocidadMaxima_kmH { get; set; }
        string Go();
        string Stop();
        string Reversa();

    }
}
