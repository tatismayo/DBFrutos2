using System;
using System.Collections.Generic;
namespace DBFrutos2.Dominio
{
    public class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Peso { get; set; }
        public decimal Valor { get; set; }
        public string Marca { get; set; }
    }
}