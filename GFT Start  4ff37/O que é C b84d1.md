# O que é Clean Code?

- Conjunto de boas práticas na escrita de software para obtenção de maior legibilidade e manutenbilidade de código
    - Clean Code: A Handbook of Agile Software Craftsmanship
    

## Regras gerais

1. Siga SEMPRE as convenções adotadas pela equipe.
2. KISS: Keep it Stupid Simple (Mantenha isto estupidamente simples).
3. Devolga o código mais limpo do que você encontrou.
4. Busque sempre entender e solucionar os problemas a partir de sua raiz.

## Regras para entedimento de código

1. Seja consistente na escrita de todo o código (mesma língua)
2. Utilize variáveis concisas e que realmente passem a informação necessária
3. Observe a necesisidade de criação de objetos de valor ao invés do uso de tipos primitivos
4. Evite dependência lógicas
5. Evite condicionais negativas

## Regras para nomeação

1. Escolher nomes descritivos para classes, variáveis e métodos
2. Para variáveis semelhantes, faça uma distinção identificável
3. Utilizar nomes de fácil leitura
4. Utilize constante para guardar strings a serem comparadas
5. Não use prefixos ou caracteres especiais

## Regras para métodos (aka funções)

1. Métodos não devem ser grandes e devem possuir somemte um objetivo/responsabilidade
2. Métodos devem possuir nomes descritivos
3. Evite a exigência de muitos parâmetros dentro de um método
4. Evite que uma função altere valores de outra classe sem ser a própria classe
5. Evite utilização de flags desnecesárias (if, cases, etc)

## Regras para comentários

1. Evite comentários desnecessária, torne seu código autoexplicativo
2. Não seja redundante
3. Não deixe código desnecessário comentado
4. Comentários podem ser úteis para falar sobre a intenção de uma classe ou método
5. Comentários podem explanar regras mais complexas e alertas sobre consequências mais sérias

## Regras para estruturação de códigos

1. Declare variáveis próximas de seu uso
2. Agrupe métodos similares
3. Declare funções de cima para baixo
4. Mantenha poucas e curtas linhas
5. Use espaçamentos e identações corretamente