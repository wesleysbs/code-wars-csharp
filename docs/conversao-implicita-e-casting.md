# Conversão implícita

**Conversão implícita** é quando o C# converte um tipo em outro **automaticamente**, sem você precisar escrever cast.

## 🧠 Regra principal

O C# permite conversão implícita quando vai de um tipo **menor → maior**.

---

## ✅ Exemplo clássico: `int` → `long`

```csharp
int a =10;
long b = a;// conversão implícita

Console.WriteLine(b);
```

Funciona porque `long` é maior que `int`.

---

## ✅ `int` → `double`

```csharp
int numero =5;
double valor = numero;

Console.WriteLine(valor);
```

Saída:

```
5
```

Sem cast.

---

## ✅ `char` → `int`

Porque `char` é um número Unicode.

```csharp
char letra ='A';
int codigo = letra;

Console.WriteLine(codigo);
```

Saída:

```
65
```

---

## ✅ `float` → `double`

```csharp
float x =10.5f;
double y = x;

Console.WriteLine(y);
```

## ❌ O contrário NÃO é implícito

Isso dá erro:

```csharp
double x =10.5;
int y = x;// ERRO
```

Porque pode perder informação.

Aí precisa de **cast explícito**.

---

## 📋 Tabela comum de conversões implícitas

```
sbyte →short →int →long →float →double →decimal
byte  →short →int →long →float →double →decimal
char  →int   →long →float →double →decimal
```

Sempre indo para tipos “maiores”.

## Por que isso existe?

Para facilitar contas:

```csharp
int a =10;
double b =2.5;

double resultado = a + b;// int vira double automaticamente
```

Conversão implícita acontece quando o C# tem certeza de que **não haverá perda de dados**.

# Casting

Casting (conversão explícita)

## 🧠 Quando o casting é necessário?

Quando pode haver **perda de dados**.

Exemplo: `double` → `int`

---

## ✅ Exemplo básico

```csharp
double valor =10.8;
int numero = (int)valor;

Console.WriteLine(numero);
```

### Saída

```
10
```

Perdeu a parte decimal.

---

## ✅ `long` → `int`

```csharp
long grande =5000;
int pequeno = (int)grande;

Console.WriteLine(pequeno);
```