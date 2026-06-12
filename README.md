# Curso C# - Exercicios SENAI

Repositorio de estudos em C# com exercicios organizados por modulo e projetos de console separados. A estrutura foi pensada para ficar simples de navegar no GitHub e facil de apresentar.

## Estrutura

```text
C-sharpe/
+-- exercicios/
|   +-- 01-aritmetica/
|   +-- 02-operadores-comparacao/
|   +-- 03-lacos-repeticao/
|   +-- 04-arrays/
|   +-- 05-revisao/
+-- projetos/
    +-- caixa-eletronico/
    +-- horta/
    +-- jokempo/
    +-- mundial-de-clubes/
    +-- pontuacao-de-jogadores/
```

## Exercicios

### 01 - Aritmetica

| Arquivo | Descricao |
|---|---|
| `ex01-area-retangulo.cs` | Calcula a area de um retangulo. |
| `ex02-area-quadrado.cs` | Calcula a area de um quadrado. |
| `ex03-operacoes-basicas.cs` | Mostra soma, subtracao, multiplicacao e divisao. |
| `ex04-conversao-litros-ml.cs` | Converte litros para mililitros. |

### 02 - Operadores de comparacao

| Arquivo | Descricao |
|---|---|
| `ex05-comparar-numeros.cs` | Compara dois numeros e informa o maior. |
| `ex06-media-notas.cs` | Calcula media de notas e informa aprovacao. |
| `ex07-comparar-frutas.cs` | Compara nomes de frutas ignorando maiusculas/minusculas. |
| `ex08-soma-vs-c.cs` | Compara a soma de A + B com C. |
| `ex09-variavel-condicional.cs` | Calcula C como soma ou produto dependendo de A e B. |

### 03 - Lacos de repeticao

| Arquivo | Descricao |
|---|---|
| `ex10-numeros-1-a-10.cs` | Exibe numeros de 1 a 10. |
| `ex11-soma-1-ate-n.cs` | Soma os numeros de 1 ate N. |
| `ex12-verificacao-senha.cs` | Valida senha e conta tentativas. |
| `ex13-contagem-regressiva.cs` | Faz contagem regressiva de 10 ate 1. |
| `ex14-calculo-25-porcento.cs` | Calcula 25% de varios valores ate digitar 0. |

### 04 - Arrays

| Arquivo | Descricao |
|---|---|
| `ex15-array-frutas.cs` | Percorre e exibe um array de frutas. |
| `ex16-media-decimais.cs` | Le 4 numeros decimais e calcula a media. |
| `ex17-dobro-inteiros.cs` | Le 6 inteiros e exibe o dobro de cada um. |
| `ex18-busca-nome.cs` | Busca um nome dentro de um array. |

### 05 - Revisao

| Arquivo | Descricao |
|---|---|
| `calculadora-imc.cs` | Calcula IMC e exibe classificacao. |

## Projetos

| Pasta | Descricao |
|---|---|
| `caixa-eletronico/` | Menu de saldo, deposito, saque e extrato. |
| `horta/` | Cadastro simples de frutas, legumes e verduras em CSV. |
| `jokempo/` | Jogo de pedra, papel e tesoura para dois jogadores. |
| `mundial-de-clubes/` | Simulacao simples de semifinais e final. |
| `pontuacao-de-jogadores/` | Tabela com vitorias, derrotas e saldo de jogadores. |

## Como executar

Os arquivos em `exercicios/` sao scripts C# individuais. Para executar com `dotnet-script`:

```bash
dotnet tool install -g dotnet-script
dotnet script exercicios/04-arrays/ex18-busca-nome.cs
```

Os projetos em `projetos/` possuem arquivo `.csproj` e podem ser executados com `dotnet run`:

```bash
dotnet run --project projetos/caixa-eletronico/caixa-eletronico.csproj
```

## Melhorias aplicadas

- Estrutura separada entre exercicios e projetos.
- Pastas com nomes padronizados, sem espacos e sem acentos.
- Remocao de arquivos gerados de build (`bin/` e `obj/`).
- Validacoes com `TryParse` nos projetos que recebiam entrada do usuario.
- README reescrito para ficar claro em apresentacao.
