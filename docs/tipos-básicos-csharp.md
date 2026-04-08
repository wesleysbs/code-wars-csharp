
O `char` em C# **não é uma letra**. `char` é um **número inteiro de 16 bits** que representa um **código Unicode**.

O que é `char` de verdade?

Em C#:

```csharp
char letra = 'A';
```

Isso **não** guarda a letra A.

Guarda o número **65** (em Unicode/ASCII).

Você pode declarar assim:

```csharp
char c ='\\u0041';// A
```

O `char` utiliza aspas simples; O ‘\u’ indica ao compilador que será inserido um código Unicode.

Depois que a string é criada, o conteúdo dela nunca mais pode ser alterado.

## Exemplo que engana iniciantes

```csharp
string nome = "Wesley";
nome = nome + " Silva";
```

Parece que você **alterou** a string.

Mas não alterou.

O que aconteceu foi:

1. `"Wesley"` continua existindo na memória
2. O C# criou **uma NOVA string** `"Wesley Silva"`
3. A variável `nome` passou a apontar para a nova

A antiga continua lá (até o GC limpar).

## Visualmente na memória

Antes:

```csharp
nome ───►"Wesley"
```

Depois:

```csharp
"Wesley"      (intacta)
"Wesley Silva"  ◄── nome
```

`object` é a **classe mãe de TODOS os tipos no C#**.

## Prova prática

Isso aqui compila:

```csharp
object a =10;// int
object b ="Wesley";// string
object c =true;// bool
object d =new DateTime();
```

Porque **todos herdam de `object`**.

## O que isso significa?

Significa que **todo tipo no C# é um objeto**.

Até os tipos primitivos:

- `int`
- `double`
- `bool`
- `char`

Eles são **structs**, mas **herdam de `object`**.

Funções para valores mínimos e máximos • int.MinValue • int.MaxValue • sbyte.MaxValue • long.MaxValue • decimal.MaxValue

## Mostrar os limites do `int`

```csharp
Console.WriteLine(int.MinValue);
Console.WriteLine(int.MaxValue);
```

Saída:

```csharp
-2147483648
2147483647
```

Overflow → Em C#, **overflow** acontece quando um número **passa do limite que o tipo da variável consegue armazenar**.

Exemplo clássico com `int`

O tipo `int` em C# usa **32 bits**.

Ele só consegue guardar valores entre:

```csharp
-2.147.483.648  até  2.147.483.647
```

Agora olha isso:

```csharp
int numero =int.MaxValue;// 2.147.483.647
numero = numero +1;

Console.WriteLine(numero);
```

### Resultado:

```csharp
-2147483648
```

Ele “voltou” para o menor valor possível.

Isso é **overflow**.

## Por que isso acontece?

Porque o computador trabalha em **binário**.

Quando passa do limite, os bits “dão a volta” (wrap around).

É como um odômetro de carro:

```csharp
9999+1=0000
```

Obs: Por padrão, o C# **NÃO avisa** quando ocorre overflow. Ele simplesmente deixa acontecer.

Dica para digitar Console.WriteLine(); mais rápido:

Digite “cw” + Tab;