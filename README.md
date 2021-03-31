# CSharp.14.Interfaces

interfaces: una interfaz solo tiene las firmas para instanciarse en la clase hija
si un metodo no esta en la interfaz no se puede usar
una clase hija puede tener metodos adicionales aparte de las firmas y lo recomendable es que sean privados
mas de una interfaz para una clase hijo, si se puede
SEALED: para este caso una clase o method sealed no puede usarse para heredarse

se declara con el keyword: interface
```csharp
public interface IPiece
```

los metodos no tienen access modifiers ni logica 
```csharp
decimal Area();
decimal Perimeter();
string GetChildType();
 ```
 
la herencia is as always:
```csharp
public class Square : IPiece
```

Los metodos ya tienen logica en la clase hija:

```csharp
public decimal Area() => Side * Side;

public decimal Perimeter() => Side * 4;

public string GetChildType() => GetType().Name;
```
