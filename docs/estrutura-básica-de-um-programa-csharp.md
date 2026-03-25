Estrutura de arquivos:

- Arquivo .slnx → (Antigo .sln) O projeto C# é uma solução, por isso, ele tem um arquivo da solução (o arquivo .slnx), é a partir desse arquivo que o programador abre o projeto.
- Arquivo .csproj → É um arquivo que diz para o .NET qual é o tipo de projeto (console, web, biblioteca, teste…); Qual versão do .NET usar; Quais pacotes (NuGet) ele precisa; Quais outros projetos ele usa; Como ele deve ser compilado.
- Classe principal .cs → É o arquivo onde fica o ponto inicial da execução. Esse arquivo inicia o programa, cria os primeiros objetos, chama outras classes, e organiza o fluxo inicial.
- Subpasta bin → Pasta onde fica armazenado o resultado final do seu build (Build é o processo de compilar seu código e gerar o programa executável).
- Subpasta obj → É a pasta onde fica armazenados arquivos temporários do build.

Program.cs:

- Cláusulas using: referências a outros namespaces → Namespace é um agrupador de classes, auxiliando para que o programador evite de escrever o nome completo das classes, dizer quais bibliotecas seu arquivo usa, organizar o código, e evitar conflito de nomes. Ex: using System;
- Namespaces → É uma pasta lógica que organiza classes e evita conflito de nomes. Ele não é obrigatório, o programa funciona sem ele. Ex:

namespace MinhaLoja.Modelos { class Cliente { } }

O nome completo dessa classe passa a ser: MinhaLoja.Modelos.Cliente

- Classe → A unidade básica da programação orientada a objetos. É o modelo que define como os objetos serão. O que o objeto **tem** (atributos / dados); O que o objeto **faz** (métodos / ações). Ex:

```csharp
class Pessoa
{
  public string Nome;
  public int Idade;

  public void Apresentar()
  {
     Console.WriteLine($"Oi, eu sou {Nome} e tenho {Idade} anos");
  }
}
```

- Método → É a ação que um objeto pode executar. Se a **classe** é o modelo, o **método** é o **comportamento** desse modelo. Ex:

```csharp
class Pessoa
{
   public string Nome;

   public void Falar()
   {
      Console.WriteLine("Olá!");
   }
}
```

- static void Main(string[] args) → É o ponto onde o programa começa a rodar.

static → Significa que o método **não precisa de objeto** para ser chamado.

void → Significa que o método **não retorna nada**.

Main → É um nome especial. O .NET procura exatamente por esse nome para saber **onde começar**.

(string[] args) → É uma lista de palavras que o programa pode receber ao iniciar pelo terminal.
