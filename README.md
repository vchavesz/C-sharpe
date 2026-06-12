# 📘 Curso C# — Exercícios SENAI

Repositório com todos os exercícios do curso de **C# (.NET 9)** realizados no SENAI Cotia.
Organizado por módulos, com código limpo, comentado e com validações de entrada.

---

## 👤 Autor

**Vinicius Chaves** — [@vchavesz](https://github.com/vchavesz)
Estudante de Desenvolvimento de Software | SENAI Cotia & Colégio Adventista Granja Viana

---

## 🗂️ Estrutura do Repositório

```
csharp-curso/
│
├── aritmetica/
│   ├── ex01-area-retangulo.cs
│   ├── ex02-area-quadrado.cs
│   ├── ex03-operacoes-basicas.cs
│   └── ex04-conversao-litros-ml.cs
│
├── operadores-comparacao/
│   ├── ex05-comparar-numeros.cs
│   ├── ex06-media-notas.cs
│   ├── ex07-comparar-frutas.cs
│   ├── ex08-soma-vs-c.cs
│   └── ex09-variavel-condicional.cs
│
├── lacos-repeticao/
│   ├── ex10-numeros-1-a-10.cs
│   ├── ex11-soma-1-ate-n.cs
│   ├── ex12-verificacao-senha.cs
│   ├── ex13-contagem-regressiva.cs
│   └── ex14-calculo-25-porcento.cs
│
├── arrays/
│   ├── ex15-array-frutas.cs
│   ├── ex16-media-decimais.cs
│   ├── ex17-dobro-inteiros.cs
│   └── ex18-busca-nome.cs
│
└── revisao/
    └── calculadora-imc.cs
```

---

## 📚 Módulos e Exercícios

### 🔢 Aritmética

| # | Arquivo | Descrição |
|---|---------|-----------|
| 01 | `ex01-area-retangulo.cs` | Calcula a área de um retângulo com base e altura fixas |
| 02 | `ex02-area-quadrado.cs` | Calcula a área de um quadrado a partir do seu lado |
| 03 | `ex03-operacoes-basicas.cs` | Realiza soma, subtração, multiplicação e divisão |
| 04 | `ex04-conversao-litros-ml.cs` | Converte litros em mililitros |

### ⚖️ Operadores de Comparação

| # | Arquivo | Descrição |
|---|---------|-----------|
| 05 | `ex05-comparar-numeros.cs` | Compara dois números inteiros e informa o maior |
| 06 | `ex06-media-notas.cs` | Calcula média de 3 notas e informa aprovação/reprovação |
| 07 | `ex07-comparar-frutas.cs` | Verifica se dois nomes de frutas são iguais |
| 08 | `ex08-soma-vs-c.cs` | Compara A+B com o valor de C |
| 09 | `ex09-variavel-condicional.cs` | Calcula C como soma ou produto dependendo de A e B |

### 🔁 Laços de Repetição

| # | Arquivo | Descrição |
|---|---------|-----------|
| 10 | `ex10-numeros-1-a-10.cs` | Imprime os números de 1 a 10 com `for` |
| 11 | `ex11-soma-1-ate-n.cs` | Soma todos os inteiros de 1 até N |
| 12 | `ex12-verificacao-senha.cs` | Valida senha com `do-while`, contando tentativas |
| 13 | `ex13-contagem-regressiva.cs` | Contagem regressiva de 10 até 1 |
| 14 | `ex14-calculo-25-porcento.cs` | Calcula 25% de valores repetidamente até digitar 0 |

### 📦 Arrays

| # | Arquivo | Descrição |
|---|---------|-----------|
| 15 | `ex15-array-frutas.cs` | Percorre e exibe um array de frutas com `for` |
| 16 | `ex16-media-decimais.cs` | Lê 4 números decimais e calcula a média |
| 17 | `ex17-dobro-inteiros.cs` | Lê 6 inteiros e exibe o dobro de cada um |
| 18 | `ex18-busca-nome.cs` | Busca um nome em um array com `foreach` |

### 🔄 Revisão

| Arquivo | Descrição |
|---------|-----------|
| `calculadora-imc.cs` | Calculadora completa de IMC com classificação via switch expression |

---

## 🛠️ Correções e Melhorias Aplicadas

Durante a organização do repositório, vários exercícios foram melhorados:

**Segurança nas entradas**
- Todos os `int.Parse()` e `double.Parse()` foram substituídos por `TryParse()`, que não causa crash quando o usuário digita letras ou deixa o campo vazio.
- Adicionado operador `??` nos `Console.ReadLine()` para lidar com valores nulos (nullable C#).

**Qualidade do código**
- Exercício 06: `int` trocado por `double` nas notas, pois médias como `7,5` eram perdidas na versão antiga.
- Exercício 07 e 18: comparação de strings agora usa `StringComparison.OrdinalIgnoreCase`, então "vinicius" e "Vinicius" são considerados iguais.
- Exercício 12: adicionado contador de tentativas.
- Exercício 14: valor inválido não encerra o loop erroneamente.
- Exercício 17: loop `for` desnecessário com variável `soma` não utilizada foi removido; `foreach` agora cobre todos os casos.
- IMC: `.Replace('.', ',')` aplicado também no peso, não só na altura.

**Organização**
- Pastas com espaço no nome (ex: `laço de repetição`) renomeadas para `lacos-repeticao` — evita problemas no terminal e no Git.
- Arquivos nomeados com padrão `exNN-descricao.cs` em vez de pasta por exercício.
- Variáveis com nomes mais claros e strings de saída mais descritivas.

---

## 🚀 Como Executar

**Pré-requisitos:** [.NET 9 SDK](https://dotnet.microsoft.com/download)

Para rodar qualquer exercício individualmente com o dotnet-script:

```bash
# Instale o dotnet-script (apenas uma vez)
dotnet tool install -g dotnet-script

# Execute um arquivo
dotnet script arrays/ex18-busca-nome.cs
```

Ou crie um projeto console simples e cole o código do exercício no `Program.cs`:

```bash
dotnet new console -n MeuExercicio
cd MeuExercicio
# cole o conteúdo do exercício em Program.cs
dotnet run
```

---

## 🎯 Conceitos Abordados

- Tipos primitivos: `int`, `double`, `string`, `bool`
- Operadores aritméticos e de comparação
- Estruturas condicionais: `if`, `else if`, `else`, `switch expression`
- Laços de repetição: `for`, `while`, `do-while`, `foreach`
- Arrays: declaração, inicialização, percurso e busca
- Entrada/saída com `Console.ReadLine()` e `Console.WriteLine()`
- Validação de entrada com `TryParse`
- Interpolação de strings com `$""`
- Formatação de números com `{valor:F2}`
- Nullable reference types e operador `??`

---

## 📈 Próximos Passos

- [ ] Módulo: Métodos e Funções
- [ ] Módulo: Orientação a Objetos (Classes, Herança, Interfaces)
- [ ] Módulo: Coleções (`List<T>`, `Dictionary<K,V>`)
- [ ] Módulo: Tratamento de Exceções (`try/catch`)
- [ ] Módulo: LINQ
- [ ] Projeto Final: Aplicação Console com CRUD

---

## 📄 Licença

Repositório de estudos — uso livre para fins educacionais.
