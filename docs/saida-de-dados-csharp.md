## O que é `ToString()`?

É um método que existe em **todos os tipos do C#**, porque vem de:

```
System.Object
```

Assinatura:

```csharp
publicvirtualstringToString();
```

> Ele converte o objeto para uma representação em texto.

## Exemplo simples

```csharp
int numero =10;

string texto = numero.ToString();

Console.WriteLine(texto);// "10"
```

O `int` virou `string`.

## Você usa sem perceber

```csharp
Console.WriteLine(10);
```

Por dentro, o C# faz:

```csharp
Console.WriteLine(10.ToString());
```

## Formatação com `ToString()`

Alguns tipos permitem formato:

```csharp
double valor =1234.567;

Console.WriteLine(valor.ToString("F2")); // 1234.57
Console.WriteLine(valor.ToString("C")); // R$ 1.234,57
```

Com datas:

```csharp
DateTime hoje = DateTime.Now;

Console.WriteLine(hoje.ToString("dd/MM/yyyy"));
```

# `System.Globalization`

`System.Globalization` é o namespace do .NET que cuida de **cultura, idioma, formatação e regras regionais**.

> Ele diz ao C# como números, datas, moedas e textos devem ser interpretados dependendo do país/idioma.

---

## 🧠 O problema que ele resolve

Olha isso:

No Brasil:

```
1.234,56   (milhar com ponto,decimal com vírgula)
```

Nos EUA:

```
1,234.56   (milhar com vírgula,decimal com ponto)
```

Sem `System.Globalization`, o C# não saberia interpretar corretamente.

## Exemplo com números

```csharp
double valor =1234.56;

Console.WriteLine(valor.ToString(new CultureInfo("pt-BR")));
Console.WriteLine(valor.ToString(new CultureInfo("en-US")));
```

Saída:

```
1234,56
1234.56
```

---

## ✅ Exemplo com moeda

```csharp
double valor = 50;

Console.WriteLine(valor.ToString("C",new CultureInfo("pt-BR")));
Console.WriteLine(valor.ToString("C",new CultureInfo("en-US")));
```

Saída:

```
R$50,00
$50.00
```

## InvariantCulture

É uma cultura **neutra**, que **não pertence a nenhum país**.

Ela usa um padrão **fixo e previsível**, independente do computador do usuário.

> É o “idioma universal” para máquinas conversarem entre si.

## O problema que ela resolve

Sem `InvariantCulture`, isso muda dependendo do Windows do usuário:

```csharp
double valor =1234.56;
Console.WriteLine(valor.ToString());
```

No Brasil:

```
1234,56
```

Nos EUA:

```
1234.56
```

Isso é perigoso para:

- Arquivos
- Banco de dados
- APIs
- Logs
- JSON
- CSV

---

## ✅ Com `InvariantCulture`

```csharp
using System.Globalization;

double valor =1234.56;

Console.WriteLine(valor.ToString(CultureInfo.InvariantCulture));
```

Saída (sempre):

```
1234.56
```

Sempre com **ponto** como decimal.

# Placeholders

São “espaços reservados” dentro de uma string onde você vai **inserir valores depois**. No C#, existem **3 formas principais** de usar placeholders.

# 1) Placeholders com `string.Format` (forma clássica)

Os placeholders são números entre chaves: `{0}`, `{1}`, `{2}`…

```csharp
string nome ="João";
int idade = 20;

string frase =string.Format("Meu nome é {0} e tenho {1} anos.", nome, idade);

Console.WriteLine(frase);
```

Saída:

```
Meu nome é João e tenho 20 anos.
```

- `{0}` → primeiro valor
- `{1}` → segundo valor

# 2) Placeholders com interpolação de string `$` (forma moderna)

Muito mais usado hoje.

```csharp
string nome ="João";
int idade =20;

string frase =$"Meu nome é {nome} e tenho{idade} anos.";

Console.WriteLine(frase);
```

Mais legível e profissional.

# 3) Placeholders com formatação

Você pode formatar números e datas dentro do placeholder.

### Com `string.Format`

```csharp
double valor =1234.5;

string texto =string.Format("Valor: {0:F2}", valor);

```

### Saída:

```
Valor:1234,57
```

`F2` = 2 casas decimais

# Interpolação

**Interpolação de string** é a forma moderna do C# de **colocar valores dentro de uma string** de maneira simples e legível. Interpolação é usar `$""` para permitir que expressões C# apareçam dentro de `{ }` na string.

## Sintaxe básica

```csharp
string nome ="João";
int idade =20;

Console.WriteLine($"Meu nome é {nome} e tenho{idade} anos.");
```

### Saída

```
Meu nome é João e tenho 20 anos.
```

# Concatenação

**Concatenação de string** é o ato de **juntar duas ou mais strings em uma só**.

No C#, isso pode ser feito de algumas formas.

## 1) Usando o operador `+` (mais comum para iniciantes)

```csharp
string nome ="João";
string sobrenome ="Ricardo";

string completo = nome + " " + sobrenome;

Console.WriteLine(completo);
```

### Saída

```
João Ricardo
```

Aqui o `+` está **unindo** as strings.

## 2) Concatenando com outros tipos

O C# converte automaticamente para string usando `ToString()`.

```csharp
int idade = 20;

string frase = "Idade: " + idade;

Console.WriteLine(frase);
```

### Saída

```
Idade: 20
```

## ⚠️ Problema da concatenação com `+`

Cada `+` cria **uma nova string na memória** (porque string é imutável).

```csharp
string texto ="";
texto = texto +"A";
texto = texto +"B";
texto = texto +"C";
```

Foram criadas várias strings desnecessárias.

## 3) Usando `string.Concat`

Faz a mesma coisa, mas de forma explícita.

```csharp
string resultado = string.Concat("João"," ","Ricardo");
```

## 4) Forma moderna (melhor que concatenação): interpolação

Em vez disso:

```csharp
string frase = nome +" tem " + idade +" anos";
```

Prefira:

```csharp
string frase =$"{nome} tem{idade} anos";
```

Mais legível.

## 5) Muitas concatenações: usar `StringBuilder`

Quando há muitas junções (loops, textos grandes):

```csharp
var sb =new StringBuilder();

sb.Append("João");
sb.Append(" ");
sb.Append("Ricardo");

Console.WriteLine(sb.ToString());
```

Muito mais performático.

O problema começa aqui:

> string é imutável.

Toda vez que você faz:

```csharp
texto = texto +"A";
```

O C#:

1. Cria uma NOVA string
2. Copia tudo da antiga
3. Adiciona "A"
4. Joga a antiga fora (pro GC limpar depois)

Se fizer isso 10.000 vezes, criou 10.000 strings.

É aí que entra o **StringBuilder**.

---

# 🧠 Ideia do StringBuilder

> Ele é uma “string mutável”.

Ele **não cria uma nova string** a cada alteração.

Ele vai **editando o mesmo bloco de memória**.

---

## ❌ Sem StringBuilder (jeito errado em loops)

```csharp
string texto ="";

for (int i =0; i <5; i++)
{
    texto +="A";
}

Console.WriteLine(texto);
```

O que acontece na memória:

```
"A"
"AA"
"AAA"
"AAAA"
"AAAAA"
```

5 strings criadas.

---

## ✅ Com StringBuilder

```csharp
using System.Text;

StringBuilder sb =new StringBuilder();

for (int i =0; i <5; i++)
{
    sb.Append("A");
}

Console.WriteLine(sb.ToString());
```

Aqui:

- Só existe **um** espaço de memória
- Ele vai acrescentando dentro dele

---

## 🧱 Visualmente

### String normal

```csharp
Heap:"A" →"AA" →"AAA" → ...
```

### StringBuilder

```csharp
Heap: [AAAAA] (mesmo lugar)
``````