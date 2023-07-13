using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Interfaces
{
    public partial class Form1 : Form
    {
        string tipoDeVehiculoAAniadir;
        string marcaVehiculoAAniadir;
        string modeloVehiculoAAniadir;
        double tiempoDeAceleracionVehiculoAAniadir;
        double velocidadVehiculoAAniadir;
        string tipoDeVehiculoNuevo;
        string marcaVehiculoNuevo;
        string modeloVehiculoNuevo;
        double tiempoDeAceleracionVehiculoNuevo;
        double velocidadVehiculoNuevo;
        List<IVehiculos> vehiculos = new List<IVehiculos>();
        int indexVehiculoAEliminar;
        int indexVehiculoAModificar;
        string vehiculosBDPath = @"C:\Users\user\Desktop\BD_Vehiculos.txt";
        public Form1()
        {
            InitializeComponent();
            ActualizarVehiculosDeArchivo_txt();
            ActualizarArchivo_txtDeVehiculos();
            comboBox1.Items.Add("auto");
            comboBox1.Items.Add("moto");
            comboBox1.Items.Add("bici");
            ActualizarComboBox2();
            comboBox3.Items.Add("auto");
            comboBox3.Items.Add("moto");
            comboBox3.Items.Add("bici");
            ActualizarComboBox4();
        }
        public void Listar()
        {
            listBox1.Items.Clear();
            for (int i = 0; i < vehiculos.Count; i++)
            {
                listBox1.Items.Add(vehiculos[i].ID + ": " + vehiculos[i].Marca + " " + vehiculos[i].Modelo + " " + vehiculos[i].TiempoDeAceleracion_segundosPor100kmH + " " + vehiculos[i].VelocidadMaxima_kmH);
            }
        }

        public void ActualizarComboBox2()
        {
            ActualizarVehiculosDeArchivo_txt();
            comboBox2.Items.Clear();
            for (int i = 0; i < vehiculos.Count; i++)
            {
                if (vehiculos[i]!=null)
                    comboBox2.Items.Add(vehiculos[i].ID + ": " + vehiculos[i].Marca + ", " + vehiculos[i].Modelo + ", " + vehiculos[i].TiempoDeAceleracion_segundosPor100kmH + ", " + vehiculos[i].VelocidadMaxima_kmH);
            }
        }

        public void ActualizarComboBox4()
        {
            ActualizarVehiculosDeArchivo_txt();
            comboBox4.Items.Clear();
            for (int i = 0; i < vehiculos.Count; i++)
            {
                if(vehiculos[i]!=null)
                    comboBox4.Items.Add(vehiculos[i].ID + ": " + vehiculos[i].Marca + ", " + vehiculos[i].Modelo + ", " + vehiculos[i].TiempoDeAceleracion_segundosPor100kmH + ", " + vehiculos[i].VelocidadMaxima_kmH);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            tipoDeVehiculoAAniadir = (string)comboBox1.SelectedItem;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            marcaVehiculoAAniadir = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            modeloVehiculoAAniadir = textBox2.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                tiempoDeAceleracionVehiculoAAniadir = Convert.ToDouble(textBox3.Text);
            }
            catch(Exception ex)
            {
                tiempoDeAceleracionVehiculoAAniadir = 0;
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            velocidadVehiculoAAniadir = Convert.ToDouble(textBox4.Text);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ActualizarVehiculosDeArchivo_txt();
            int idNuevo = vehiculos.Count + 1;

            switch (tipoDeVehiculoAAniadir)
            {
                case "auto":
                    vehiculos.Add(new Auto(idNuevo, tipoDeVehiculoAAniadir, marcaVehiculoAAniadir, modeloVehiculoAAniadir, tiempoDeAceleracionVehiculoAAniadir, velocidadVehiculoAAniadir));
                    break;
                case "moto":
                    vehiculos.Add(new Moto(idNuevo, tipoDeVehiculoAAniadir, marcaVehiculoAAniadir, modeloVehiculoAAniadir, tiempoDeAceleracionVehiculoAAniadir, velocidadVehiculoAAniadir));
                    break;
                case "bici":
                    vehiculos.Add(new Bici(idNuevo, tipoDeVehiculoAAniadir, marcaVehiculoAAniadir, modeloVehiculoAAniadir, tiempoDeAceleracionVehiculoAAniadir, velocidadVehiculoAAniadir));
                    break;
            }
            ActualizarArchivo_txtDeVehiculos();
            Listar();
            ActualizarComboBox2();
            ActualizarComboBox4();
        }
        


        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {
            ActualizarVehiculosDeArchivo_txt();
            for (int i = 0; i < vehiculos.Count; i++)
            {
                if (indexVehiculoAEliminar == i)
                {
                    vehiculos.RemoveAt(i);
                }
            }
            ActualizarArchivo_txtDeVehiculos();
            Listar();
            ActualizarComboBox2();
            ActualizarComboBox4();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            tipoDeVehiculoNuevo = (string)comboBox3.SelectedItem;
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            marcaVehiculoNuevo = textBox12.Text;
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            modeloVehiculoNuevo = textBox11.Text;
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            if (textBox10.Text != null)
                tiempoDeAceleracionVehiculoNuevo = Convert.ToDouble(textBox10.Text);
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            if (textBox9.Text != null)
                velocidadVehiculoNuevo = Convert.ToDouble(textBox9.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void label7_Click(object sender, EventArgs e)
        {

        }



        private void label6_Click(object sender, EventArgs e)
        {

        }
        private void button3_Click(object sender, EventArgs e)
        {
            ActualizarVehiculosDeArchivo_txt();
            int idNuevo = indexVehiculoAModificar + 1;
            switch (tipoDeVehiculoNuevo)
            {
                case "auto":
                    vehiculos[indexVehiculoAModificar]=new Auto(idNuevo, tipoDeVehiculoNuevo, marcaVehiculoNuevo, modeloVehiculoNuevo, tiempoDeAceleracionVehiculoNuevo, velocidadVehiculoNuevo);
                    break;
                case "moto":
                    vehiculos[indexVehiculoAModificar]=new Moto(idNuevo, tipoDeVehiculoNuevo, marcaVehiculoNuevo, modeloVehiculoNuevo, tiempoDeAceleracionVehiculoNuevo, velocidadVehiculoNuevo);
                    break;
                case "bici":
                    vehiculos[indexVehiculoAModificar]=new Bici(idNuevo, tipoDeVehiculoNuevo, marcaVehiculoNuevo, modeloVehiculoNuevo, tiempoDeAceleracionVehiculoNuevo, velocidadVehiculoNuevo);
                    break;
            }
            ActualizarArchivo_txtDeVehiculos();
            Listar();
            ActualizarComboBox2();
            ActualizarComboBox4();
        }
        private void comboBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string stringVehiculoAEliminar = (string)comboBox2.Text;
            int idVehiculoAEliminar = Convert.ToInt32(stringVehiculoAEliminar.Substring(0, 1));
            for (int i = 0; i < vehiculos.Count; i++)
            {
                if (vehiculos[i].ID == idVehiculoAEliminar)
                {
                    indexVehiculoAEliminar = i;
                }
            }
        }
        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string _stringVehiculoAModificar = (string)comboBox4.Text;
            int _idVehiculoAModificar = Convert.ToInt32(_stringVehiculoAModificar.Substring(0, 1));
            for (int i = 0; i < vehiculos.Count; i++)
            {
                if (vehiculos[i].ID == _idVehiculoAModificar)
                {
                    indexVehiculoAModificar = i;
                }
            }
        }

        public void ActualizarVehiculosDeArchivo_txt()
        {
            vehiculos.Clear();
            IEnumerable <string> lines = File.ReadAllLines(vehiculosBDPath);
            String.Join(Environment.NewLine, lines);
            vehiculos.Clear();
            for (int i=0; i < lines.Count(); i++)
            {
                string[] _arrayLinea= lines.ElementAt(i).Split('\t');
                switch (_arrayLinea[1])
                {
                    case "auto":
                        vehiculos.Add(new Auto(Convert.ToInt32(_arrayLinea[0]),_arrayLinea[1], _arrayLinea[2], _arrayLinea[3], Convert.ToDouble(_arrayLinea[4]), Convert.ToDouble(_arrayLinea[5])));
                        break;
                    case "moto":
                        vehiculos.Add(new Moto(Convert.ToInt32(_arrayLinea[0]), _arrayLinea[1], _arrayLinea[2], _arrayLinea[3], Convert.ToDouble(_arrayLinea[4]), Convert.ToDouble(_arrayLinea[5])));
                        break;
                    case "bici":
                        vehiculos.Add(new Bici(Convert.ToInt32(_arrayLinea[0]), _arrayLinea[1], _arrayLinea[2], _arrayLinea[3], Convert.ToDouble(_arrayLinea[4]), Convert.ToDouble(_arrayLinea[5])));
                        break;
                }
            }
        }
        public void ActualizarArchivo_txtDeVehiculos()
        {
            File.Delete(vehiculosBDPath);
            List<string> _lineas = new List<string>();
            for (int i = 0; i < vehiculos.Count; i++)
            {
                _lineas.Add(Convert.ToString(vehiculos[i].ID) + '\t' + vehiculos[i].Tipo + '\t' + vehiculos[i].Marca + '\t' + vehiculos[i].Modelo + '\t' + Convert.ToString(vehiculos[i].TiempoDeAceleracion_segundosPor100kmH) + '\t' + Convert.ToString(vehiculos[i].VelocidadMaxima_kmH));
            }
            File.WriteAllLines(vehiculosBDPath, _lineas);
        }
        public void EliminarVehiculo(IVehiculos _vehiculoAEliminar)
        {
            for (int i = 0; i < vehiculos.Count; i++) 
            {
                if (vehiculos[i] == _vehiculoAEliminar)
                {
                    vehiculos.RemoveAt(i);
                }
            }
            ActualizarArchivo_txtDeVehiculos();
        }
        public void AgregarVehiculo(IVehiculos _vehiculoAAgregar)
        {
            switch(_vehiculoAAgregar.Tipo) 
            {
                case "auto":
                    vehiculos.Add(new Auto (_vehiculoAAgregar.ID, _vehiculoAAgregar.Tipo, _vehiculoAAgregar.Marca, _vehiculoAAgregar.Modelo, _vehiculoAAgregar.TiempoDeAceleracion_segundosPor100kmH, _vehiculoAAgregar.VelocidadMaxima_kmH));
                    break;
                case "moto":
                    vehiculos.Add(new Moto(_vehiculoAAgregar.ID, _vehiculoAAgregar.Tipo, _vehiculoAAgregar.Marca, _vehiculoAAgregar.Modelo, _vehiculoAAgregar.TiempoDeAceleracion_segundosPor100kmH, _vehiculoAAgregar.VelocidadMaxima_kmH));
                    break;
                case "bici":
                    vehiculos.Add(new Bici(_vehiculoAAgregar.ID, _vehiculoAAgregar.Tipo, _vehiculoAAgregar.Marca, _vehiculoAAgregar.Modelo, _vehiculoAAgregar.TiempoDeAceleracion_segundosPor100kmH, _vehiculoAAgregar.VelocidadMaxima_kmH));
                    break;
            }
            ActualizarArchivo_txtDeVehiculos();
        }
    }
}