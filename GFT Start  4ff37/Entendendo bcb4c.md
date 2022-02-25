# Entendendo .NET e .NET Core

![Untitled](Entendendo%20bcb4c/Untitled.png)

Plataforma unificada → Para várias plataformas

## Sobre .NET Core e .NET

- Plataforma cruzada: Linux, Windows e Mac OS
- Produzir um produto com base de código única
- Open Source → MIT e Apache 2
- .NET = .NET Core + .NET Framework + Xamarin + Mono
- Aquisição facilitada a partir do NUGET
- Modular e com melhor desempenho
- Ciclos de lançamentos

## Sobre [ASP.Net](http://ASP.Net) Core

→ Construção de aplicações web, IoT apps e aplicações backend pra mobile

→ Funcionalidades para construção de aplicações com renderização no servidor

- Uso do MVC → [ASP.NET](http://ASP.NET) Core MVC
    - Uso de Padrão MVC (Model-View-Controller)
    1. **Model:** Representa o estado da aplicação, encapsulando lógica de negócio
    2. **View:** Responsável por apresentar dados através de interface
    3. **Controller:** Componentes que lidam com a interação do usuário a partir da View e trabalham com a model para apresentar respostas para o usuário
    
    ---
    
- Model Binding
    
    → Mapeamento automático de dados de requisições HTTP para parâmetros de métodos de ação
    
- Model Validation: Validação automática no lado do cliente e servidor

---

## Razor Pages e Razor markup

- Modelo baseado em páginas → simplificado
- Interface e lógica de negócio são separados, mas dentro da página.
- Sintaxe de marcação para inserir código baseado em .NET em páginas web = Razor markup + C# + HTML

---

## Tag Helpers

- Permite que o código do lado do servidor participe da criação e renderização de elementos HTML em arquivos Razor
- Experi~encia de desenvolvimento com HTML mais amigável
- IntelliSense no ambiente para sintaxe HTML e Razor
- Manunteção de código usando somente informações do servidor

---

## Blazor (funcionalidades para construção de aplicações com renderização no cliente)

- Framework para construir aplicativos do lado do cliente que são executados direito no navegador com WebAssembly (WASM) usando C#
- Uso da interoperabilidade com Javascript para lidar com manipulação DOM
- Integração com frameworks como Angular, React e Bootstrap