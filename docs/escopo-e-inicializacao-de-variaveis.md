# Escopo (scope)

Onde a variável existe e pode ser usada no código. Em C#, o escopo é definido pelas **chaves `{ }`**.

## Exemplo 1 — variável dentro do `if`

```csharp
if (true)
{
int x =10;
    Console.WriteLine(x);// funciona
}

Console.WriteLine(x);// ERRO
```

Erro porque `x` **só existe dentro do bloco** do `if`.

## Exemplo 2 — variável fora do bloco

```csharp
int x;

if (true)
{
    x =10;
}

Console.WriteLine(x);// funciona
```

Aqui funciona porque `x` foi declarada fora.

Regra do escopo: A variável só existe **dentro das chaves onde foi criada**.

# Inicialização de variáveis

Inicializar é dar um valor para a variável antes de usar.

## ❌ Exemplo com erro

```csharp
int x;
Console.WriteLine(x);// ERRO
```

Erro:

```csharp
Use of unassignedlocal variable'x'
```

Porque você declarou, mas não inicializou.

## ✅ Correto

```csharp
int x = 0;
Console.WriteLine(x);
```

## ⚠️ Situação clássica com `if`

```csharp
int x;

if (true)
{
    x = 10;
}

Console.WriteLine(x);// funciona
```

Mas agora veja:

```csharp
int x;

if (false)
{
    x = 10;
}

Console.WriteLine(x);// ERRO
```

O compilador pensa:

> “Pode ser que esse if não execute… então x pode ficar sem valor.”

## ✅ Forma correta

```csharp
int x =0;

if (false)
{
    x =10;
}

Console.WriteLine(x);
```