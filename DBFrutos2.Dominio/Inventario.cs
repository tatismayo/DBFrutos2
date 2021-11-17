using System;
using System.Collections.Generic;

namespace DBFrutos2.Dominio
{
    public class Inventario
    {
        public int Id { get; set; }
        public Usuario Usuario { get; set; }
        public Producto Producto { get; set; }
        public int Stock { get; set; }
        public DateTime Fecha_Entrada { get; set; }
        public DateTime Fecha_Salida { get; set; }
    }
}