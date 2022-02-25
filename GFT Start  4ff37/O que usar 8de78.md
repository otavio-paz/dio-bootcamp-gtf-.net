# O que usar? Quando usar?

- Use .NET quando:
    - Necessitar de plataforma cruzada
    - Há direcionamento de microsserviços
        - Azure Service Fabric
        - Azure App Service
    - Uso de Docker
        - Hospedagem em infraestrutura Linux ou Windows
        - Azure Kurbenetes Service
    - Alto desemepnho e sistemas escalonáveis
    - Necesisdades de versões .NET diferentes por aplicação

- Use .NET Framework quando:
    - Não houver necessidade de migração para .NET
    - Bibliotecas de terceiros ou pacotes NUGET não são disponíveis para .NET
    - Necessidade de tecnologias não disponíveis para .NET
        - [ASP.NET](http://ASP.NET) WebForms
        - [ASP.NET](http://ASP.NET) Web Pages não estão incluídos no ASP.NET Core
        - Implementação do lado servidor para WCF
        - Workflow Foundation, Workflow Services e Workflow Data Services
    - Quando o projeto não suporte determinada linguagem para o caso de Visual Basic e F#
    
    ![Untitled](O%20que%20usar%208de78/Untitled.png)