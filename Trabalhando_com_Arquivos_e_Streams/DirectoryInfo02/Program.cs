using static System.Console;

var path = @"C:\Users\pazot\Desktop\Projects\Git\Digital Innovation One\dio-bootcamp-gtf-.net\Trabalhando_com_Arquivos_e_Streams\Directory_DirectoryInfo\globo";
LerDiretorios(path);

WriteLine("Pressione [enter] para finalizar... ");
ReadLine();

static void LerDiretorios(string path)
{
    if (Directory.Exists(path))
    {
        var diretorios = Directory.GetDirectories(path, "*", SearchOption.AllDirectories);
        foreach (var dir in diretorios)
        {
            var dirInfo = new DirectoryInfo(dir);
            WriteLine($"[Nome]:{dirInfo.Name}");
            WriteLine($"[Raiz]:{dirInfo.Root}");
            if (dirInfo.Parent != null)
                WriteLine($"[Pai]{dirInfo.Parent.Name}"); //nem sempre tem o pai
            WriteLine("---------");
        }
    }
    else
    {
        WriteLine($"{path} não existe");
    }

}