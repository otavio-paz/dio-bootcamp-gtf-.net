var path = @"C:\";
using var fsw = new FileSystemWatcher(path);
//como o FSW tem o IDisposable implementado, é recomendado usar o using 

fsw.Created += OnCreated;
fsw.Created += OnDeleted;
fsw.Created += OnRenamed;

fsw.EnableRaisingEvents = true; //para permitir q os eventos sejam disparados
fsw.IncludeSubdirectories = true; //permitir para subdiretorios

Console.WriteLine($"Monitorando eventos no caminho: {path}");
Console.WriteLine("Pressione [enter] para finalizar...");
Console.ReadLine();

void OnCreated(object sender, FileSystemEventArgs e)
{
    Console.WriteLine($"Foi criado o arquivo {e.Name}");
}



void OnDeleted(object sender, FileSystemEventArgs e)
{
     Console.WriteLine($"Foi excluido o arquivo {e.Name}");
}



void OnRenamed(object sender, FileSystemEventArgs e)
{
     Console.WriteLine($"O arquivo {e.OldName} Foi renomeado o arquivo {e.Name}");
}