using System.Collections.Generic;

namespace DBFrutos2.Dominio
{
    public class Factura
    {
        public int Id { get; set; }
        public Pedido Pedido { get; set; }
        public Usuario Usuario { get; set; }
    }
}