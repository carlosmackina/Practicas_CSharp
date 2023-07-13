using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class Auto : IVehiculos
    {
        public string Go()
        {
            return "El auto se esta moviendo para adelante";
        }
        public string Stop()
        {
            return "El auto esta detenido";
        }
        public string Reversa()
        {
            return "El auto se esta moviendo para atras";
        }
        public int ID { get; set; }
        public string Tipo { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public double TiempoDeAceleracion_segundosPor100kmH { get; set; }
        public double VelocidadMaxima_kmH { get; set; }
        public Auto(int _id, string _tipo, string _marca,string _modelo, double _tiempoDeAcelaracion, double _velocidadMaxima)
        {
            this.ID = _id;
            this.Tipo = _tipo;
            this.Marca = _marca;
            this.Modelo = _modelo;
            this.TiempoDeAceleracion_segundosPor100kmH = _tiempoDeAcelaracion;
            this.VelocidadMaxima_kmH = _velocidadMaxima;
        }
    }
    public class Moto : IVehiculos
    {
        public string Go()
        {
            return "La moto se esta moviendo para adelante";
        }
        public string Stop()
        {
            return "La moto esta detenida";
        }
        public string Reversa()
        {
            return "La moto se esta moviendo para atras";
        }
        public int ID { get; set; }
        public string Tipo { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public double TiempoDeAceleracion_segundosPor100kmH { get; set; }
        public double VelocidadMaxima_kmH { get; set; }
        public Moto(int _id, string _tipo, string _marca, string _modelo, double _tiempoDeAcelaracion, double _velocidadMaxima)
        {
            this.ID = _id;
            this.Tipo = _tipo;
            this.Marca = _marca;
            this.Modelo = _modelo;
            this.TiempoDeAceleracion_segundosPor100kmH = _tiempoDeAcelaracion;
            this.VelocidadMaxima_kmH = _velocidadMaxima;
        }
    }
    public class Bici : IVehiculos
    {
        public string Go()
        {
            return "La bici se esta moviendo para adelante";
        }
        public string Stop()
        {
            return "L esta detenido";
        }
        public string Reversa()
        {
            return "El auto se esta moviendo para atras";
        }
        public int ID { get; set;}
        public string Tipo { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public double TiempoDeAceleracion_segundosPor100kmH { get; set; }
        public double VelocidadMaxima_kmH { get; set; }
        public Bici(int _id, string _tipo, string _marca, string _modelo, double _tiempoDeAcelaracion, double _velocidadMaxima)
        {
            this.ID = _id;
            this.Tipo = _tipo;
            this.Marca = _marca;
            this.Modelo = _modelo;
            this.TiempoDeAceleracion_segundosPor100kmH = _tiempoDeAcelaracion;
            this.VelocidadMaxima_kmH = _velocidadMaxima;
        }
    }
}
