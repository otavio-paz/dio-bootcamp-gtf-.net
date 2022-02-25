# Convenções de nomenclatura

## Notação Húngara

→ Não é recomendada

![Untitled](Convenc%CC%A7o%CC%83%206cc94/Untitled.png)

## Camel Case

→ Escrever palavras ou frases compostas considerando a primeira palavra SEMPRE MINÚSCULA e as subsquentes MAIÚSCULAS.

Ex: valorDoDesconto, nomeCompleto, totalSalario, etc

## Pascal Case

→ Escrever palavras ou frases compostas considerando a primeira letra de CADA palavra MAÍUSCULA

Ex: ValorDoDesconto, NomeCompleto, TotalSalario, etc

# Qual o padrão para C#?

- Não há uma regra obrigatória, porém grande maioria dos desenvolvedores convenciona da seguinte forma:
    - Nomes de classes e métodos → Pascal Case
    - Nomes de variáveis e parâmetros → Camel Case
- No caso de interfaces, recomenda-se o uso do prefixo “ I “
    - Ex: IEntidade, IRespositorioCliente, etc
    

## Recomendações da Microsoft

- Uso do PascalCase
    - Classes
    - Interfaces
    - Membros de tipos públicos
- Uso com CamelCase
    - Campos privados e internos → deve-se ainda usá-los com prefixo “_”
    - Campo estáticos privados ou internos → usar com prefixo “s_”