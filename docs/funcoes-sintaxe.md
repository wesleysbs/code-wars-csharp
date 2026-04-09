## Função

É um bloco de código que faz uma tarefa específica e tem um nome.

## Exemplos que você JÁ usa

```csharp
Math.Sqrt(9);// calcula raiz
Console.WriteLine();// escreve na tela
```

Você não sabe como foram feitas por dentro.

Só usa.

Isso é o poder da função.

# 🎯 Vantagens

|Vantagem|Significa|
|---|---|
|Modularização|Quebra o programa em partes menores|
|Delegação|Cada função faz só uma coisa|
|Reaproveitamento|Usa várias vezes sem reescrever|

# Estrutura de uma função

```csharp
tipoRetorno NomeFuncao(parametros)
{
			// processamento
			return valor;
}
```

# Exemplo 1 — Função que SOMA

```csharp
staticintSomar(int a,int b)
{
int resultado = a + b;
return resultado;
}
```

Usando no `Main`:

```csharp
int r = Somar(10,5);
Console.WriteLine(r);
```

Saída:

```csharp
15
```

---

## 🧠 Aqui temos

- Entrada → `a` e `b`
- Processamento → `a + b`
- Saída → `return resultado`

# Exemplo 2 — Função que NÃO retorna nada

```csharp
staticvoidMensagem()
{
    Console.WriteLine("Olá, Wesley!");
}
```

Usando:

```csharp
Mensagem();
```

`void` = não devolve nada.

Uma função pode produzir dois tipos de resultado:

|Tipo de resultado|Exemplo|
|---|---|
|**Valor**|número, texto, bool|
|**Ação (efeito colateral)**|imprimir na tela, salvar arquivo, alterar variável, tocar som|

Funções `void` existem para o segundo caso.

---

## ✅ Exemplo clássico: `Console.WriteLine`

```csharp
Console.WriteLine("Oi");
```

Ela retorna algo? ❌

Mas faz algo? ✅

Ela **age no mundo** (mostra na tela).

---

## ✅ Exemplo seu

```csharp
staticvoidMostrarMensagem()
{
    Console.WriteLine("Bem-vindo!");
}
```

Uso:

```csharp
MostrarMensagem();
```

Ela não devolve nada, mas **executa uma ação**.