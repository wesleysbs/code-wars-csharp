# Console.ReadLine()

Ler o que o usuário digita no teclado (uma linha inteira)

## O que ele retorna?

Sempre retorna:

```csharp
string
```

Mesmo que o usuário digite número.

---

## ✅ Exemplo mais simples

```csharp
Console.Write("Digite seu nome: ");
string nome = Console.ReadLine();

Console.WriteLine("Olá " + nome);
```

Se o usuário digitar:

```csharp
Pedro
```

Saída:

```csharp
Olá Pedro
```

---

## ⚠️ Ponto MAIS IMPORTANTE

Se a pessoa digitar `10`, isso ainda é:

```csharp
"10"  (string)
```

Não é número.

# Split

**Quebrar uma string em vários pedaços**, usando um **separador**.

Ele retorna:

```csharp
string[]
```

(um vetor de strings)

## Imagine que o usuário digita:

```
10 20 30
```

Isso é **uma única string**:

```
"10 20 30"
```

---

## ✅ Usando `Split(' ')`

```csharp
string[] v = Console.ReadLine().Split(' ');
```

O `' '` é o **espaço**.

O C# vai quebrar a string toda vez que encontrar um espaço.

O vetor `v` fica assim:

|Índice|Valor|
|---|---|
|v[0]|"10"|
|v[1]|"20"|
|v[2]|"30"|

---

## ✅ Pegando cada parte

```csharp
string a = v[0];
string b = v[1];
string c = v[2];
```

Agora:

```
a ="10"
b ="20"
c ="30"
```

Ainda são **strings**.

## Pode usar outros separadores

Vírgula:

```csharp
"10,20,30".Split(',')
```

Hífen:

```csharp
"10-20-30".Split('-')
```

`Split` transforma **uma string grande** em **várias pequenas**, usando um separador.

# Parse

serve para:

> Converter uma string em um número (ou outro tipo)

Porque tudo que vem do teclado é `string`.

## Exemplo clássico com `int`

```csharp
string texto ="10";
int numero =int.Parse(texto);

Console.WriteLine(numero +5);
```

Saída:

```
15
```

## Usando direto com `ReadLine`

```csharp
int numero = int.Parse(Console.ReadLine());
```

Se o usuário digitar `20`, vira o número 20.

# O que é `FormatException`?

É o erro que acontece quando:

> O texto não está no formato esperado para virar número (ou data, etc).

## Exemplo clássico

```csharp
int numero =int.Parse("abc");
```

Erro:

```
System.FormatException:Input string wasnotin a correctformat.
```

Porque `"abc"` **não tem formato de número**.

## Quando o `FormatException` acontece?

Quando você usa:

- `int.Parse`
- `double.Parse`
- `DateTime.Parse`
- etc.

E a string não está no formato correto.