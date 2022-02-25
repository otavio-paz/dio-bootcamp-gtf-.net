# O que usar para cada tipo de aplicação?

## Aplicações desktop

- Universal Windows Apps
- Windows Presentation Foundation (WPF)
- Windows Forms
- Xamarin.MAC

---

## Aplicações baseadas em containers

**AZURE**: Plataforma de nuvem completa que pode hospedar aplicativos e simplificar o desenvolvimento de novos aplicativos

- Para aplicações monolíticas → Azure App Service
- Aplicações com arquiteturas em camadas → Azure Kurbenetes Service (ABS)
- Microserviços: AKS ou Azure Web Apps para Containers
- Funções Serveless e event handlers: Azure Functions
- Processamento Batch de larga escala: Azure Batch

---

## Outros serviços Azure para desenvolvedores

- **Azure SQL**: Versão em nuvem do SQL Server
- **Azure Cosmos DB**: Banco de dados NoSQL com escalabilidade e de API compatível com MongoDB
- **Azure Blob Storage**: Armazenamento em nuvem de arquivos, prezando pela escalabilidade, redundância de dados e disponibilidade.
- **Azure Key Vault**: Permite o armazenamento em nuvem de segredos de aplicações, como connection strings e chaves de APIs.
- **Cognitive Services**: Coleção de serviços em nuvem que permite a adição de Inteligência Artificial para aplicações, com funcionalidades como reconhecimento de falar, compreensão de linguagens e detecção de anomalias.

---

## Aprendizagem de máquina com .NET

- ML.NET
    - Framework de aprendizagem de máquina de plataforma cruzada e open source
    - Criação de modelos de aprendizagem de máquina a partir de interface gráfica (Model Builder) ou por meio do [ML.NET](http://ML.NET) CLI
    - Integração com outros frameworks famosos como TensorFlow, ONNX, INFER.NET
- Tipos de predições com o ML.NET:
    - Classificação e categorização de objetos
    - Predição de valores contínuos
    - Detecção de anomalias
    - Recomendações
    - Análise de sentimento

---

## Desenvolvimento de Jogos

- Unity: Plataforma de desenvolvimento de jogos 3D e em tempo real, disponível para Windows e macOS
- MonoGame: Framework multiplataforma, open-source com suporte para .NET Core e .NET 4.5
- Godot: Game engine gratuita e open-source, para desenvolvimento de jogos usando C#
- Stide: Plataforma para desenvolvimento de jogos 2D/3D gratuita, multiplataforma, open source e com editor robusto e gráficos realistas.
- Wave Engine: Mecanismo gratuito para desenvolvimento gráfico voltado para negócios e indústria. Constrói soluções de alta qualidade 3D e 2D.
- FlatRedBall: Plataforma de desenvolvimento de jogos 2D, construído em cima do MonoGame.
- CRYENGINE: Framework para desenvolvimento de jogos usando .NET e C#. Disponível para Windows e Linux.

---

## Internet das Coisas (IoT)

- Bibliotecas específicas para integração de aplicações com hardware especilizado como sensores, dispositivos LCD, conversores analógico-digital
    - System.Device.Gpio
    - Iot.Device.Bindings
- Suportado em muitas versões do Linux que suportam ARM/ARM64 e Windows IoT Core
- .NET NanoFramework
    - Plataforma gratuita e open-source que permite o desenvolvimento de aplicações com C# acoplados a dispositivos.
    - É suportado pela .NET Foundation.
    - Utilização do Visual Studio
- Meadow
    - Plataforma IoT e full-stack que permite construir soluções focadas para indústria de forma segura e escalável
    - Integrado com Azure
    - Uso no Visual Studio