``` csharp
 + → adição
 - → subtração
 * → multiplicação
 / → divisão
 % → resto da divisão
```


O operador “ % “ lê-se “mod”.

## Precedência

Os operadores * / % tem precedência maior que + -

Quando dois operadores aritméticos possuem a mesma precedência em uma conta, realiza-se a conta da esquerda para a direita.

```csharp
int resultado =10 /8;
Console.WriteLine(resultado);
```

### O que o C# faz internamente

1. `10` é `int`
2. `8` é `int`
3. Então ele faz **divisão inteira**

```csharp
10 / 8 = 1   (não é 1.25)
```

A parte `.25` **nunca existiu**.

Depois ele guarda `1` no `int`.

## 🧠 O que realmente acontece (ordem real)

O C# avalia **a expressão primeiro**, **antes** de pensar na variável.

Olhe para a linha:

```csharp
int resultado = 10 / 8;
```

O compilador enxerga assim:

```csharp
resultado = (10 / 8);
```

Ele precisa resolver **(10 / 8)** antes.

---

## ⚙️ Como ele resolve `10 / 8`?

Ele olha os tipos:

- 10 → `int`
- 8 → `int`

Regra da linguagem:

> int / int = divisão inteira

Então ele calcula:

```csharp
10 / 8 = 1
```

**Nesse momento já virou 1.**

O número 1.25 **nunca existiu** na execução.

---

## Só depois ele guarda

Agora que a conta já deu 1, ele faz:

```csharp
int resultado = 1;
```

---

## 🧪 Prova prática disso

Veja:

```csharp
double x = 10 / 8;
Console.WriteLine(x);
```

Sai:

```csharp
1
```

Se 1.25 tivesse existido, apareceria aqui.

Mas não aparece, porque **a conta já foi inteira**.

---

## 💡 Agora compare com isso

```csharp
double x = 10.0 / 8;
```

Aqui muda tudo, porque:

- 10.0 → `double`
- 8 → `int`

Regra:

> double / int = double

Então agora a conta é:

```csharp
10.0 / 8 = 1.25
```

---

## 🧠 A chave que faltava

> O C# decide como fazer a conta antes de saber onde você vai guardar.

Ele não olha para `int resultado`.

Ele olha apenas para:

```csharp
10 / 8
```

## ✅ Como fazer dar 1.25

Você precisa forçar a conta a ser feita em ponto flutuante.

Basta UM dos números não ser `int`.

```csharp
double resultado =10.0 /8;
Console.WriteLine(resultado);
```

ou

```csharp
double resultado = (double)10 /8;
```

ou

```csharp
double resultado =10 /8.0;
```

### Saída

```csharp
1.25
```

# Math.Pow

É a função usada para **potenciação** no C#. Calcula: **base elevado ao expoente.**

## Sintaxe

```csharp
Math.Pow(base, expoente);
```

Ela retorna um **double**.

## Exemplo básico

```csharp
double resultado = Math.Pow(2,3);
Console.WriteLine(resultado);
```

### Saída

```csharp
8
```

Porque:

`2³ = 8`

## ⚠️ Sempre retorna `double`

Mesmo que o resultado seja inteiro:

```csharp
double r = Math.Pow(3,2);// 9
```

Se você quiser `int`:

```csharp
int r = (int)Math.Pow(3,2);
```

# Math.Sqrt

É a função para calcular **raiz quadrada** no C#.

## Sintaxe

```csharp
Math.Sqrt(valor);
```

Retorna **double**.

---

## ✅ Exemplo básico

```csharp
double r = Math.Sqrt(9);
Console.WriteLine(r);
```

### Saída

```csharp
3
```

---

## ✅ Outro exemplo

```csharp
double r = Math.Sqrt(2);
Console.WriteLine(r);
```

Saída aproximada:

```csharp
1.41421356237
```

Porque a raiz de 2 não é exata.

---

## ⚠️ Sempre retorna `double`

Mesmo quando a raiz é inteira:

```csharp
double r = Math.Sqrt(16);// 4.0
```

Se quiser `int`:

```csharp
int r = (int)Math.Sqrt(16);// 4
```

---

## ❗ Cuidado com números negativos

```csharp
double r = Math.Sqrt(-9);
Console.WriteLine(r);
```

Saída:

```csharp
NaN
```

> NaN = Not a Number

Raiz quadrada real de número negativo não existe.