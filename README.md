# C# for .NET Developers

## Conceptos:

### .NET Core:

- Se conoce como un usbconjunto mas grande de .NET Framework.
- Las aplicaciones son mas modulares, ligeras, rápidas, flexibles y modernas.

1. Open source
2. Cross-Platform
3. Modular Architecture
4. Supports Multiple Languages
5. Consistent
6. CLI Tool
7. Flexible Deployment
8. Compatibility

### .NET FRAMEWORK vs .NET CORE

#### .NET CORE

- Es una plataforma de desarrollo de propósito general para desarrollar aplicaciones de software modernas basadas en la nube en diferentes sistemas operativos. Ofrece código abierto, multiplataforma, alto rendimiento y multiples entornos.
- Open source
- Compatible con Windows, Linux, Mac OS
- No soporta el desarrollo de aplicaciones de escritorio, se centra mas en web
- Ofrece un alto rendimiento y escalabilidad

#### .NET FRAMEWORK

- Algunos componentes son open source, la mayoria son de paga.
- Windows
- se utiliza para aplicaciones de escritorio y web
- Ofrece menos rendimiento y escalabilidad que .NET Core

##### Crear Proyecto

- dotnet new list
- dotnet new console -n coreConsoleProject
- dotnet build
- dotnet run

#### .NET Core Framework

- CLI Tools:
- Roslyn:compilador de c# y visual basic
- CoreFX: proporciona un conjunto de frameworks
- CoreCLR: es un componente de la plataforma .NET Core que proporciona el entorno de ejecución para las aplicaciones .NET Core.

### Programación orientada a objetos:

- Clases: La estructura utilizando métodos y propiedades que se asemejan a la entidad del mundo real.[Capos, propiedades, metodos]
- Objetos: Es el principal componente importante que ayuda a acceder a los miembros de la clase. Son instancias de la clase que contienen diferentes datos en campos de propiedades y tambien pueden interactuar con otros objetos.
- Encapsulación: Ocultación de datos. Se necesita abstraerlos con ayuda de modificadores de acceso.
- Abstracción: Modificadores de acceso: publicos, privados protegidos e internos
- Herencia: Reutilización de datos
- Polimorfismo: Signidica una interfaz, multiples funciones donde una misma operación se va a realizar en diferentes entidades.
