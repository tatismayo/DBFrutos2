using System;
using System.Collections.Generic;
namespace DBFrutos2.Dominio
{
    public class Usuario
    {
        public int Id { get; set; }
        public TipoUsuario Tipousuario { get; set; }
        public string Nombre { get; set; }
        public int Documento { get; set; }
        public int Telefono { get; set; }
        public string Direccion { get; set; }
        public string Email { get; set; }
        public string Ciudad { get; set; }
    }
}