using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class BancoDeDados
    {

        public static void Salvar(Usuario usuario)
        {
            AppDbContext db = new AppDbContext();

            db.Usuarios.Add(usuario);

            db.SaveChanges();
        }

        public static List<Usuario> BuscarTodosUsuarios()
        {
            AppDbContext db = new AppDbContext();

            List<Usuario> usuarios = db.Usuarios.ToList();

            return usuarios;
        }

        public static void DeletarUsuario(int id)
        {
            AppDbContext db = new AppDbContext();

            Usuario usuario = db.Usuarios.Find(id);

            if (usuario == null)
            {
                Console.WriteLine("Usuário não encontrado");
                return;
            }

            db.Usuarios.Remove(usuario);
            db.SaveChanges();

        }
    }
}
