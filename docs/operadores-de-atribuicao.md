
# Operador +=

O operador `+=` com `string` é uma forma **abreviada de concatenação**.

## Exemplo simples

```csharp
string nome = "Pedro";

nome += " Roberto";

Console.WriteLine(nome);
```

### Saída

```
Pedro Roberto
```

Isso é o mesmo que escrever:

```csharp
nome = nome + " Roberto";
```

## ⚠️ O que acontece por trás (importante)

Cada `+=` cria **uma nova string** na memória, porque string é imutável.

Ou seja, isso:

```csharp
texto +="A";
texto +="B";
texto +="C";
```

Cria:

```
"A"
"AB"
"ABC"
```

Várias strings temporárias.

---

## ✅ Em pequenos casos, sem problema

Para poucas concatenações, `+=` é totalmente aceitável.

Para loops grandes → `StringBuilder`.

## 🧠 O que significa `a++`?

Significa:

> usa o valor atual de a primeiro
> 
> **depois incrementa**

Ordem exata:

1. Pega o valor atual de `a`
2. Usa esse valor na expressão
3. Só depois soma 1 em `a`

---

## 🔍 Passo a passo do seu código

```csharp
int a =10;
int b = a++;
```

### Linha 1

```
a =10
```

### Linha 2 — `b = a++`

O que acontece internamente:

1. Valor atual de `a` = **10**
2. Esse valor vai para `b`
3. Depois `a` é incrementado para **11**

Agora temos:

```
a =11
b =10
```

---

## 🖨️ Impressão

```csharp
Console.WriteLine(a);// 11
Console.WriteLine(b);// 10
```

---

## 🧠 Compare com o pré-incremento `++a`

Se fosse:

```csharp
int a =10;
int b = ++a;
```

A ordem muda:

1. Incrementa `a` primeiro → 11
2. Usa o valor novo na expressão

Resultado:

```
a = 11
b = 11
```

---

## 📌 Regra mental definitiva

|Operador|O que acontece primeiro|
|---|---|
|`a++`|Usa, depois soma|
|`++a`|Soma, depois usa|