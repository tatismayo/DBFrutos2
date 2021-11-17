using System.Collections.Generic;
using DBFrutos2.Dominio;

namespace DBFrutos2.Persistencia
{
    public interface IRepositorioUsuario
    {
        //IEnumerable<Usuario> GetAllUsuario();
        Usuario AddUsuario(Usuario usuario);
        /*
        Usuario UpdateUsuario(Usuario usuario);
        void DeleteUsuario(int idUsuario);    
        Usuario GetUsuario(int idUsuario);
        Pedido AsignarPedido(int idUsuario, int idPedido);
        TipoUsuario AsignarTipoUsuario(int idUsuario, int idTipoUsuario);
        */
    }
}