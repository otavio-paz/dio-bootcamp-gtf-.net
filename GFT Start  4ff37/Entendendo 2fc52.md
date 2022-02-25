# Entendendo Xamarin

## Sobre Xamarin

- Plataforma para desenvolvimento de aplicações mobile modernas com alto desempenho
- Baseado no projeto Mono, implementação open source baseada no .NET Framework
- Criação de interface nativa em cada plataforma (android, iOS, MacOS e Windows apps) e código de lógica compartilhado
- Possui todos os benefícios já citados da plataforma .NET

## Como funciona?

![Untitled](Entendendo%202fc52/Untitled.png)

### Xamarin.Forms

- Framework open source para desenvolvimento de interfaces para o usuário
- Aplicativos Android, iOS e Windows com única base de código
- Criação de UI com XAML e lógica com C#
- Uso de biblioteca Xamarin.Essentials
    - Informações de dispositivos
    - Sistema de arquivos
    - Acelerômetro
    - Bloqueio de tela...

### Xamarin.Android

- Compillação de C# para LI (linguagem intermediária), que por sua vez, é compilado para assembly nativo no momento da execução
- Executado no ambiente Mono + ART

### Xamarin.iOS

- Compilação total de C# para código assembly nativo
- Executado no ambiente Mono + AOT (ahead of time)
- Restrição de segurança: sem permissão para execução de código gerado dinamicamente