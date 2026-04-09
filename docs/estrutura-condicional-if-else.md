## `if` simples

Executa **só se** a condição for verdadeira.

```csharp
int idade =20;

if (idade >=18)
{
    Console.WriteLine("Maior de idade");
}
```

## `if / else`

Um caminho ou outro.

```csharp
int numero =5;

if (numero %2 ==0)
{
    Console.WriteLine("Par");
}
else
{
    Console.WriteLine("Ímpar");
}
```

## `if / else if / else`

Várias possibilidades, mas **só uma executa**.

```csharp
int nota =7;

if (nota <5)
{
    Console.WriteLine("Reprovado");
}
elseif (nota <7)
{
    Console.WriteLine("Recuperação");
}
else
{
    Console.WriteLine("Aprovado");
}
```

## Operador ternário (condicional em uma linha)

Forma reduzida de `if / else`.

```csharp
int idade =18;

string resultado = idade >=18 ?"Maior" :"Menor";

Console.WriteLine(resultado);
```

# Problema de usar 3 if separados

**Todos os `if` são testados**, mesmo quando um já deveria “resolver” a decisão.

## Exemplo do erro

```csharp
int numero = 5;

if (numero > 0)
{
    Console.WriteLine("Positivo");
}

if (numero < 10)
{
    Console.WriteLine("Menor que 10");
}

if (numero == 5)
{
    Console.WriteLine("É cinco");
}
```

Saída:

```csharp
Positivo
Menor que 10
É cinco
```

## O problema real dos 3 `if` aparece quando as condições se sobrepõem

Por exemplo:

```csharp
int idade =10;

if (idade <18)
    Console.WriteLine("Menor de idade");

if (idade <12)
    Console.WriteLine("Criança");
```

Saída:

```csharp
Menor de idade
Criança
```