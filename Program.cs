using ConsoleApp1;

Usuario usuarioss = new Usuario();
usuarioss.Email = "qualquercoisa@teste.com";
usuarioss.Senha = "qualquercoisa";

List<Usuario> usuarios = BancoDeDados.BuscarTodosUsuarios();

foreach (Usuario usuario in usuarios)
    {
    Console.WriteLine($"Email: {usuario.Email} , senha: {usuario.Senha}");
    }


BancoDeDados.DeletarUsuario(1);


