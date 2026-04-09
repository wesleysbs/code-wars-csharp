O `while` é a estrutura de repetição mais simples do C#. Ele repete um bloco de código **enquanto** a condição for verdadeira.

## Estrutura

```csharp
while (condicao)
{
// código que repete
}
```

---

## ✅ Exemplo 1 — Contagem simples

```csharp
int i =1;while (i <=5)
{
    Console.WriteLine(i);
    i++;
}
```

### Saída

```csharp
1
2
3
4
5
```

---

## 🧠 Como o `while` pensa

1. Testa a condição
2. Se for `true` → executa o bloco
3. Volta e testa de novo
4. Repete até virar `false`

## ⚠️ Erro clássico: loop infinito

```csharp
int i =1;while (i <=5)
{
    Console.WriteLine(i);
}
```

Esqueceu o `i++`.

A condição nunca muda → nunca para.