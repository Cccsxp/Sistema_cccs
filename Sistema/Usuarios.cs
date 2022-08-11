using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema
{
    class Usuarios
    {
        int id, id_tipo;
        string usuario, password, conPassword, nombre, direccion, telefono, cedula, ciudad, documento, correo, area;

        public string Usuario { get => usuario; set => usuario = value; }
        public string Password { get => password; set => password = value; }
        public string ConPassword { get => conPassword; set => conPassword = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Id { get => id; set => id = value; }
        public int Id_tipo { get => id_tipo; set => id_tipo = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Cedula { get => cedula; set => cedula = value; }
        public string Ciudad { get => ciudad; set => ciudad = value; }
        public string Correo { get => correo; set => correo = value; }
        public string Documento { get => documento; set => documento = value; }

        public string Area { get => area; set => area = value; }
    }
}
