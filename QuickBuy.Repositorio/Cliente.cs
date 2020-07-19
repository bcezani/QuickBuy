using QuickBuy.Dominio.Entidades;
using QuickBuy.Repositorio.Repositorios;

namespace QuickBuy.Repositorio
{
    public class Cliente
    {
        public Cliente()
        {
            UsuarioRepositorio usuarioRepositorio = new UsuarioRepositorio();
            Usuario usuario = new Usuario();

            usuarioRepositorio.Adicionar(usuario);
        }
    }
}
