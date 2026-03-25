## 🐪 Camel Case

Primeira letra **minúscula**.

Usado para:

- Variáveis locais
- Parâmetros de métodos

```csharp
string firstName = "Wesley";
int totalValue = 10;
```

Em parâmetros:

```csharp
voidPrintUser(string userName,int userAge)
{
}
```

## 🏛️ Pascal Case

Primeira letra **maiúscula** em cada palavra.

Usado para:

- Classes
- Métodos
- Propriedades
- Namespaces

```csharp
classUserProfile
{
publicstring FirstName {get;set; }

publicvoidPrintUserData()
    {
    }
}
```

## 🔒 Padrão `_lastName` (campo interno da classe)

Chamado de **private field convention**.

- Começa com `_`
- Camel case depois
- Usado para atributos privados (internos)

```csharp
classUserProfile
{
privatestring _lastName;
privateint _age;

publicvoidSetData(string lastName,int age)
    {
        _lastName = lastName;
        _age = age;
    }
}
```

## Exemplo completo juntando tudo

```csharp
namespaceMyApp.Models
{
classUserProfile
    {
privatestring _lastName;// campo interno
privateint _age;// campo interno

publicstring FirstName {get;set; }// propriedade (Pascal)

publicvoidSetUserData(string lastName,int age)// parâmetros (camel)
        {
            _lastName = lastName;
            _age = age;
        }
    }
}
```

## 📌 Resumo rápido

|Convenção|Onde usar|Exemplo|
|---|---|---|
|camelCase|variáveis e parâmetros|`firstName`, `userAge`|
|PascalCase|classes, métodos, propriedades|`UserProfile`, `PrintData`|
|`_camelCase`|atributos privados|`_lastName`, `_totalValue`|