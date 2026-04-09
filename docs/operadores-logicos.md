## Precedência

```csharp
! > && > ||
```

Obs: Pode-se usar parêntesis caso fique confuso.

## Operador AND `&&`

Só é `true` se **as duas condições** forem verdadeiras.

```csharp
int idade =20;
bool temCarteira =true;

if (idade >=18 && temCarteira)
{
    Console.WriteLine("Pode dirigir");
}
```

## Operador OR `||`

É `true` se **pelo menos uma** for verdadeira.

```csharp
int idade =16;
bool autorizadoPais =true;

if (idade >=18 || autorizadoPais)
{
    Console.WriteLine("Pode entrar");
}
```

## Operador NOT `!`

Inverte o valor.

```csharp
bool chovendo =false;

if (!chovendo)
{
    Console.WriteLine("Vou sair de casa");
}
```