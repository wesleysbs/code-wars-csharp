# Debugging

**É executar o programa passo a passo** para ver o que está acontecendo por dentro.

# O que é Debugging?

É usar ferramentas do Visual Studio para:

- Pausar o programa
- Ver valores das variáveis em tempo real
- Executar linha por linha
- Entender onde está o erro lógico

---

# 🎯 Ferramenta principal: Breakpoint

O breakpoint é o **ponto de pausa**.

Você clica na lateral da linha e aparece uma bolinha vermelha.

Quando rodar em modo Debug, o programa **para ali**.

---

## ✅ Exemplo

```csharp
int a =10;int b =8;int resultado = a / b;// breakpoint aqui
Console.WriteLine(resultado);
```

Quando parar, você consegue ver:

```csharp
a = 10
b = 8
```

Antes da conta acontecer.

# 🧠 Step Over vs Step Into

Se tiver uma função:

```csharp
int r = Somar(10,5);
```

- **F10 (Step Over)** → executa a função sem entrar
- **F11 (Step Into)** → entra dentro da função para ver o que acontece