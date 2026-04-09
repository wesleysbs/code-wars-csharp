O `for` é um **while organizado** para quando você **sabe quantas vezes vai repetir**.

---

## 🧠 Ideia do `for`

> “Repita isso X vezes”

---

## 🧱 Estrutura

```csharp
for (início; condição; incremento)
{
	// código
}
```

## ✅ Exemplo básico

```csharp
for (int i =1; i <=5; i++)
{
    Console.WriteLine(i);
}
```

Saída:

```csharp
1
2
3
4
5
```

## 🔍 O que cada parte faz

### 1️⃣ Início

```csharp
int i = 1;
```

Só executa **uma vez**, no começo.

---

### 2️⃣ Condição

```csharp
i <= 5
```

Testada **antes de cada volta**.

---

### 3️⃣ Incremento

```csharp
i++
```

Executa **depois** do bloco, a cada volta.